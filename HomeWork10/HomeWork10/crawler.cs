using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
namespace HomeWork10
{
	class crawler
	{
		public event Action<crawler> CrawlerStopped;
		public event Action<crawler, string, string> PageDownloaded;

		
		private ConcurrentDictionary<string, bool> urls = new ConcurrentDictionary<string, bool>();	
		private ConcurrentQueue<string> pending = new ConcurrentQueue<string>();
		private readonly string urlDetectRegex = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
		public static readonly string urlParseRegex = @"^(?<site>https?://(?<host>[\w.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";
		public string HostFilter { get; set; } 
		public string FileFilter { get; set; } 
		public int MaxPage { get; set; }
		public string StartURL { get; set; } 
		public Encoding HtmlEncoding { get; set; } //网页编码
		public ConcurrentDictionary<string, bool> DownloadedPages { get => urls; } 

		private string gridLock = "gridLock";
		private string fileLock = "fileLock";

		private int downLoadNum = 1;

		public crawler()
		{
			MaxPage = 25;
			HtmlEncoding = Encoding.UTF8;
		}

		public void Start()
		{
			urls.Clear();
			downLoadNum = 1;
			pending = new ConcurrentQueue<string>();
			pending.Enqueue(StartURL);
			List<Task> tasks = new List<Task>();
			do
			{
				pending.TryDequeue(out string url);
				try
				{
					if (url != null)
					{
						Task task = Task.Run(() => ConcurrentDownLoad(url));
						tasks.Add(task);
					}
				}
				catch (AggregateException ex)
				{
					foreach (Exception inner in ex.InnerExceptions)
					{
						Console.WriteLine(
							"Exception type {0} from {1}",
							inner.GetType(), inner.Source);
					}
				}
			} while (tasks.Count < this.MaxPage);
			Task.WaitAll(tasks.ToArray());
			CrawlerStopped(this);
		}

		private void ConcurrentDownLoad(string url)
		{
			urls[url] = true;
			string html = DownLoad(url); // 下载
			lock (gridLock)
			{
				PageDownloaded(this, url, "success");
			}
			Parse(html, url);//解析
		}

		private string DownLoad(string url)
		{
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			string html = webClient.DownloadString(url);
			lock (fileLock)
			{
				string fileName = downLoadNum.ToString();
				File.WriteAllText(fileName, html, Encoding.UTF8);
				downLoadNum++;
			}
			return html;
		}

		private void Parse(string html, string pageUrl)
		{
			var matches = new Regex(urlDetectRegex).Matches(html);
			foreach (Match match in matches)
			{
				string linkUrl = match.Groups["url"].Value;
				if (linkUrl == null || linkUrl == "") continue;
				linkUrl = FixUrl(linkUrl, pageUrl);									
				Match linkUrlMatch = Regex.Match(linkUrl, urlParseRegex);
				string host = linkUrlMatch.Groups["host"].Value;
				string file = linkUrlMatch.Groups["file"].Value;
				if (file == "") file = "index.html";
				if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter))
				{
					if (!urls.ContainsKey(linkUrl))
					{
						pending.Enqueue(linkUrl);
						urls.TryAdd(linkUrl, false);
					}
				}
			}
		}


		static private string FixUrl(string url, string pageUrl)
		{
			if (url.Contains("://"))
			{
				return url;
			}
			if (url.StartsWith("//"))
			{
				return "http:" + url;
			}
			if (url.StartsWith("/"))
			{
				Match urlMatch = Regex.Match(pageUrl, urlParseRegex);
				String site = urlMatch.Groups["site"].Value;
				return site.EndsWith("/") ? site + url.Substring(1) : site + url;
			}

			if (url.StartsWith("../"))
			{
				url = url.Substring(3);
				int idx = pageUrl.LastIndexOf('/');
				return FixUrl(url, pageUrl.Substring(0, idx));
			}

			if (url.StartsWith("./"))
			{
				return FixUrl(url.Substring(2), pageUrl);
			}

			int end = pageUrl.LastIndexOf("/");
			return pageUrl.Substring(0, end) + "/" + url;
		}
	}
}
