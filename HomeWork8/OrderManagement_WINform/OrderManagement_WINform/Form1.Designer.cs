namespace OrderManagement_WINform
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.quary = new System.Windows.Forms.Button();
			this.add = new System.Windows.Forms.Button();
			this.modify = new System.Windows.Forms.Button();
			this.export = new System.Windows.Forms.Button();
			this.import = new System.Windows.Forms.Button();
			this.delete = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.itemDataBinding = new System.Windows.Forms.BindingSource(this.components);
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDataBinding = new System.Windows.Forms.BindingSource(this.components);
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.itemDataBinding)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataBinding)).BeginInit();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.comboBox1);
			this.flowLayoutPanel1.Controls.Add(this.textBox1);
			this.flowLayoutPanel1.Controls.Add(this.quary);
			this.flowLayoutPanel1.Controls.Add(this.add);
			this.flowLayoutPanel1.Controls.Add(this.modify);
			this.flowLayoutPanel1.Controls.Add(this.export);
			this.flowLayoutPanel1.Controls.Add(this.import);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 43);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "全部订单",
            "订单号",
            "客户",
            "商品名称"});
			this.comboBox1.Location = new System.Drawing.Point(8, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(107, 23);
			this.comboBox1.TabIndex = 3;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(121, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(160, 25);
			this.textBox1.TabIndex = 4;
			// 
			// quary
			// 
			this.quary.Location = new System.Drawing.Point(287, 8);
			this.quary.Name = "quary";
			this.quary.Size = new System.Drawing.Size(73, 30);
			this.quary.TabIndex = 1;
			this.quary.Text = "查询";
			this.quary.UseVisualStyleBackColor = true;
			this.quary.Click += new System.EventHandler(this.quary_Click);
			// 
			// add
			// 
			this.add.Location = new System.Drawing.Point(366, 8);
			this.add.Name = "add";
			this.add.Size = new System.Drawing.Size(102, 30);
			this.add.TabIndex = 0;
			this.add.Text = "添加订单";
			this.add.UseVisualStyleBackColor = true;
			this.add.Click += new System.EventHandler(this.add_Click);
			// 
			// modify
			// 
			this.modify.Location = new System.Drawing.Point(474, 8);
			this.modify.Name = "modify";
			this.modify.Size = new System.Drawing.Size(94, 30);
			this.modify.TabIndex = 2;
			this.modify.Text = "修改订单";
			this.modify.UseVisualStyleBackColor = true;
			this.modify.Click += new System.EventHandler(this.modify_Click);
			// 
			// export
			// 
			this.export.Location = new System.Drawing.Point(574, 8);
			this.export.Name = "export";
			this.export.Size = new System.Drawing.Size(94, 30);
			this.export.TabIndex = 6;
			this.export.Text = "导出订单";
			this.export.UseVisualStyleBackColor = true;
			this.export.Click += new System.EventHandler(this.export_Click);
			// 
			// import
			// 
			this.import.Location = new System.Drawing.Point(674, 8);
			this.import.Name = "import";
			this.import.Size = new System.Drawing.Size(107, 30);
			this.import.TabIndex = 7;
			this.import.Text = "导入订单";
			this.import.UseVisualStyleBackColor = true;
			// 
			// delete
			// 
			this.delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.delete.Location = new System.Drawing.Point(666, 10);
			this.delete.Name = "delete";
			this.delete.Size = new System.Drawing.Size(117, 30);
			this.delete.TabIndex = 5;
			this.delete.Text = "删除订单";
			this.delete.UseVisualStyleBackColor = true;
			this.delete.Click += new System.EventHandler(this.delete_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.delete);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 391);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 59);
			this.panel1.TabIndex = 6;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 43);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 348);
			this.panel2.TabIndex = 7;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.dataGridView2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(399, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(401, 348);
			this.panel4.TabIndex = 1;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.itemDataBinding;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 0);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.RowTemplate.Height = 27;
			this.dataGridView2.Size = new System.Drawing.Size(401, 348);
			this.dataGridView2.TabIndex = 0;
			// 
			// itemDataBinding
			// 
			this.itemDataBinding.DataMember = "Item";
			this.itemDataBinding.DataSource = this.orderDataBinding;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(399, 348);
			this.panel3.TabIndex = 0;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.orderDataBinding;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 27;
			this.dataGridView1.Size = new System.Drawing.Size(399, 348);
			this.dataGridView1.TabIndex = 0;
			// 
			// orderNumberDataGridViewTextBoxColumn
			// 
			this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn.HeaderText = "订单号";
			this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
			// 
			// customerDataGridViewTextBoxColumn
			// 
			this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
			this.customerDataGridViewTextBoxColumn.HeaderText = "客户";
			this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "总金额";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			this.amountDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderDataBinding
			// 
			this.orderDataBinding.DataSource = typeof(OrderManagement.Order);
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// totalpriceDataGridViewTextBoxColumn
			// 
			this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "totalprice";
			this.totalpriceDataGridViewTextBoxColumn.HeaderText = "totalprice";
			this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
			this.totalpriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Form1";
			this.Text = "订单管理系统";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.itemDataBinding)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDataBinding)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button quary;
		private System.Windows.Forms.Button add;
		private System.Windows.Forms.Button modify;
		private System.Windows.Forms.Button export;
		private System.Windows.Forms.Button import;
		private System.Windows.Forms.Button delete;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.BindingSource itemDataBinding;
		private System.Windows.Forms.BindingSource orderDataBinding;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
	}
}

