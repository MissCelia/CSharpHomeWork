using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace OrderManagement
{
	public class OSContext : DbContext
	{
		public OSContext() : base("OSDataBase")
		{
			Database.SetInitializer(
				new DropCreateDatabaseIfModelChanges<OSContext>());
		}

	
		public DbSet<OrderItem> OrderItems { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
