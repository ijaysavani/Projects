namespace FeniImpex
{
	partial class ManageOrders
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.CustomersGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.OrderIdTb = new ns1.BunifuMaterialTextbox();
			this.CustId = new ns1.BunifuMaterialTextbox();
			this.orderdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.SearchCombo = new System.Windows.Forms.ComboBox();
			this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.QtyTb = new ns1.BunifuMaterialTextbox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.OrderGv = new Guna.UI2.WinForms.Guna2DataGridView();
			this.CustName = new ns1.BunifuMaterialTextbox();
			this.label7 = new System.Windows.Forms.Label();
			this.TotAmount = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.DimGray;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(956, 100);
			this.panel1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(925, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "X";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(341, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manage Orders";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(349, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(241, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "FENI IMPEX®";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 688);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(956, 12);
			this.panel2.TabIndex = 21;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(108, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(157, 24);
			this.label4.TabIndex = 32;
			this.label4.Text = "CUSTOMERS LIST";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// CustomersGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.CustomersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.CustomersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CustomersGV.BackgroundColor = System.Drawing.Color.White;
			this.CustomersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.CustomersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.CustomersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.CustomersGV.ColumnHeadersHeight = 25;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.CustomersGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.CustomersGV.EnableHeadersVisualStyles = false;
			this.CustomersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CustomersGV.Location = new System.Drawing.Point(12, 136);
			this.CustomersGV.Name = "CustomersGV";
			this.CustomersGV.RowHeadersVisible = false;
			this.CustomersGV.RowTemplate.Height = 30;
			this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.CustomersGV.Size = new System.Drawing.Size(359, 235);
			this.CustomersGV.TabIndex = 33;
			this.CustomersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.CustomersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.CustomersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CustomersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
			this.CustomersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.CustomersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.CustomersGV.ThemeStyle.HeaderStyle.Height = 25;
			this.CustomersGV.ThemeStyle.ReadOnly = false;
			this.CustomersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.CustomersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.CustomersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustomersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CustomersGV.ThemeStyle.RowsStyle.Height = 30;
			this.CustomersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.CustomersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
			// 
			// OrderIdTb
			// 
			this.OrderIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.OrderIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OrderIdTb.ForeColor = System.Drawing.Color.Black;
			this.OrderIdTb.HintForeColor = System.Drawing.Color.Empty;
			this.OrderIdTb.HintText = "";
			this.OrderIdTb.isPassword = false;
			this.OrderIdTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.OrderIdTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.OrderIdTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.OrderIdTb.LineThickness = 4;
			this.OrderIdTb.Location = new System.Drawing.Point(108, 379);
			this.OrderIdTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.OrderIdTb.Name = "OrderIdTb";
			this.OrderIdTb.Size = new System.Drawing.Size(157, 41);
			this.OrderIdTb.TabIndex = 34;
			this.OrderIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.OrderIdTb.OnValueChanged += new System.EventHandler(this.OrderIdTb_OnValueChanged);
			// 
			// CustId
			// 
			this.CustId.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CustId.Enabled = false;
			this.CustId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustId.ForeColor = System.Drawing.Color.Black;
			this.CustId.HintForeColor = System.Drawing.Color.Empty;
			this.CustId.HintText = "";
			this.CustId.isPassword = false;
			this.CustId.LineFocusedColor = System.Drawing.Color.Blue;
			this.CustId.LineIdleColor = System.Drawing.Color.Maroon;
			this.CustId.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.CustId.LineThickness = 4;
			this.CustId.Location = new System.Drawing.Point(12, 430);
			this.CustId.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.CustId.Name = "CustId";
			this.CustId.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CustId.Size = new System.Drawing.Size(216, 41);
			this.CustId.TabIndex = 35;
			this.CustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.CustId.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
			// 
			// orderdate
			// 
			this.orderdate.CheckedState.Parent = this.orderdate;
			this.orderdate.FillColor = System.Drawing.Color.LightCoral;
			this.orderdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
			this.orderdate.ForeColor = System.Drawing.SystemColors.InfoText;
			this.orderdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.orderdate.HoverState.Parent = this.orderdate;
			this.orderdate.Location = new System.Drawing.Point(14, 557);
			this.orderdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.orderdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.orderdate.Name = "orderdate";
			this.orderdate.ShadowDecoration.Parent = this.orderdate;
			this.orderdate.Size = new System.Drawing.Size(216, 26);
			this.orderdate.TabIndex = 36;
			this.orderdate.Value = new System.DateTime(2021, 8, 12, 23, 35, 6, 652);
			this.orderdate.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.DimGray;
			this.label5.Location = new System.Drawing.Point(63, 527);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 27);
			this.label5.TabIndex = 37;
			this.label5.Text = "Order Date";
			//this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// SearchCombo
			// 
			this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.SearchCombo.ForeColor = System.Drawing.Color.Black;
			this.SearchCombo.FormattingEnabled = true;
			this.SearchCombo.Location = new System.Drawing.Point(550, 104);
			this.SearchCombo.Name = "SearchCombo";
			this.SearchCombo.Size = new System.Drawing.Size(177, 29);
			this.SearchCombo.TabIndex = 39;
			this.SearchCombo.Text = "Select Category";
			this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
			// 
			// ProductsGV
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
			this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.ProductsGV.ColumnHeadersHeight = 25;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle6;
			this.ProductsGV.EnableHeadersVisualStyles = false;
			this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProductsGV.Location = new System.Drawing.Point(377, 136);
			this.ProductsGV.Name = "ProductsGV";
			this.ProductsGV.RowHeadersVisible = false;
			this.ProductsGV.RowTemplate.Height = 30;
			this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProductsGV.Size = new System.Drawing.Size(567, 235);
			this.ProductsGV.TabIndex = 38;
			this.ProductsGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.ProductsGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.ProductsGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.ProductsGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.ProductsGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.ProductsGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.ProductsGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProductsGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
			this.ProductsGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ProductsGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProductsGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.ProductsGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.ProductsGV.ThemeStyle.HeaderStyle.Height = 25;
			this.ProductsGV.ThemeStyle.ReadOnly = false;
			this.ProductsGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.ProductsGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.ProductsGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.ProductsGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProductsGV.ThemeStyle.RowsStyle.Height = 30;
			this.ProductsGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProductsGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
			// 
			// QtyTb
			// 
			this.QtyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.QtyTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.QtyTb.ForeColor = System.Drawing.Color.Black;
			this.QtyTb.HintForeColor = System.Drawing.Color.Empty;
			this.QtyTb.HintText = "";
			this.QtyTb.isPassword = false;
			this.QtyTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.QtyTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.QtyTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.QtyTb.LineThickness = 4;
			this.QtyTb.Location = new System.Drawing.Point(479, 415);
			this.QtyTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.QtyTb.Name = "QtyTb";
			this.QtyTb.Size = new System.Drawing.Size(203, 25);
			this.QtyTb.TabIndex = 40;
			this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(377, 416);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(94, 24);
			this.label6.TabIndex = 41;
			this.label6.Text = "Quantity";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Crimson;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(681, 408);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(154, 32);
			this.button1.TabIndex = 42;
			this.button1.Text = "Add to Order";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// OrderGv
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
			this.OrderGv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.OrderGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.OrderGv.BackgroundColor = System.Drawing.Color.White;
			this.OrderGv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.OrderGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.OrderGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.OrderGv.ColumnHeadersHeight = 25;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.OrderGv.DefaultCellStyle = dataGridViewCellStyle9;
			this.OrderGv.EnableHeadersVisualStyles = false;
			this.OrderGv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.OrderGv.Location = new System.Drawing.Point(281, 453);
			this.OrderGv.Name = "OrderGv";
			this.OrderGv.RowHeadersVisible = false;
			this.OrderGv.RowTemplate.Height = 30;
			this.OrderGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.OrderGv.Size = new System.Drawing.Size(663, 199);
			this.OrderGv.TabIndex = 43;
			this.OrderGv.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.OrderGv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.OrderGv.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.OrderGv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.OrderGv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.OrderGv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.OrderGv.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.OrderGv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.OrderGv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
			this.OrderGv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.OrderGv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OrderGv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.OrderGv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.OrderGv.ThemeStyle.HeaderStyle.Height = 25;
			this.OrderGv.ThemeStyle.ReadOnly = false;
			this.OrderGv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.OrderGv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.OrderGv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.OrderGv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.OrderGv.ThemeStyle.RowsStyle.Height = 30;
			this.OrderGv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.OrderGv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// CustName
			// 
			this.CustName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.CustName.Enabled = false;
			this.CustName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CustName.ForeColor = System.Drawing.Color.Black;
			this.CustName.HintForeColor = System.Drawing.Color.Empty;
			this.CustName.HintText = "";
			this.CustName.isPassword = false;
			this.CustName.LineFocusedColor = System.Drawing.Color.Blue;
			this.CustName.LineIdleColor = System.Drawing.Color.Maroon;
			this.CustName.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.CustName.LineThickness = 4;
			this.CustName.Location = new System.Drawing.Point(14, 481);
			this.CustName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.CustName.Name = "CustName";
			this.CustName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CustName.Size = new System.Drawing.Size(216, 41);
			this.CustName.TabIndex = 44;
			this.CustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(467, 657);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(157, 22);
			this.label7.TabIndex = 45;
			this.label7.Text = "Total Amount Rs";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// TotAmount
			// 
			this.TotAmount.AutoSize = true;
			this.TotAmount.BackColor = System.Drawing.Color.Transparent;
			this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TotAmount.Location = new System.Drawing.Point(630, 655);
			this.TotAmount.Name = "TotAmount";
			this.TotAmount.Size = new System.Drawing.Size(0, 25);
			this.TotAmount.TabIndex = 46;
			this.TotAmount.Click += new System.EventHandler(this.TotAmount_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Crimson;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(3, 589);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 32);
			this.button2.TabIndex = 47;
			this.button2.Text = "INSERT ORDER";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Crimson;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.White;
			this.button3.Location = new System.Drawing.Point(139, 589);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(114, 32);
			this.button3.TabIndex = 48;
			this.button3.Text = "VIEW ORDERS";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F);
			this.label8.Location = new System.Drawing.Point(18, 398);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 22);
			this.label8.TabIndex = 49;
			this.label8.Text = "OrderId";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Crimson;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(92, 627);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(83, 32);
			this.button4.TabIndex = 50;
			this.button4.Text = "Home";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// ManageOrders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 700);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.TotAmount);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.CustName);
			this.Controls.Add(this.OrderGv);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.QtyTb);
			this.Controls.Add(this.SearchCombo);
			this.Controls.Add(this.ProductsGV);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.orderdate);
			this.Controls.Add(this.CustId);
			this.Controls.Add(this.OrderIdTb);
			this.Controls.Add(this.CustomersGV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageOrders";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageOrders";
			this.Load += new System.EventHandler(this.ManageOrders_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2DataGridView CustomersGV;
		private ns1.BunifuMaterialTextbox OrderIdTb;
		private ns1.BunifuMaterialTextbox CustId;
		private Guna.UI2.WinForms.Guna2DateTimePicker orderdate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox SearchCombo;
		private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
		private ns1.BunifuMaterialTextbox QtyTb;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button1;
		private Guna.UI2.WinForms.Guna2DataGridView OrderGv;
		private ns1.BunifuMaterialTextbox CustName;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label TotAmount;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button4;
	}
}