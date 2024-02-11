namespace FeniImpex
{
	partial class ManageProducts
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ProdIdTb = new ns1.BunifuMaterialTextbox();
			this.ProdNameTb = new ns1.BunifuMaterialTextbox();
			this.QtyTb = new ns1.BunifuMaterialTextbox();
			this.PriceTb = new ns1.BunifuMaterialTextbox();
			this.DescriptionTb = new ns1.BunifuMaterialTextbox();
			this.CatCombo = new System.Windows.Forms.ComboBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.ProductsGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			this.SearchCombo = new System.Windows.Forms.ComboBox();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
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
			this.panel1.Size = new System.Drawing.Size(1025, 100);
			this.panel1.TabIndex = 3;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(991, 0);
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
			this.label2.Location = new System.Drawing.Point(323, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(249, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manage Products";
			this.label2.Click += new System.EventHandler(this.label2_Click);
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
			this.panel2.Location = new System.Drawing.Point(0, 563);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1025, 12);
			this.panel2.TabIndex = 20;
			// 
			// ProdIdTb
			// 
			this.ProdIdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdIdTb.ForeColor = System.Drawing.Color.Black;
			this.ProdIdTb.HintForeColor = System.Drawing.Color.Empty;
			this.ProdIdTb.HintText = "";
			this.ProdIdTb.isPassword = false;
			this.ProdIdTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.ProdIdTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.ProdIdTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.ProdIdTb.LineThickness = 4;
			this.ProdIdTb.Location = new System.Drawing.Point(25, 128);
			this.ProdIdTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ProdIdTb.Name = "ProdIdTb";
			this.ProdIdTb.Size = new System.Drawing.Size(216, 41);
			this.ProdIdTb.TabIndex = 5;
			this.ProdIdTb.Text = "ProductId";
			this.ProdIdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ProdIdTb.OnValueChanged += new System.EventHandler(this.ProdIdTb_OnValueChanged);
			// 
			// ProdNameTb
			// 
			this.ProdNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.ProdNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProdNameTb.ForeColor = System.Drawing.Color.Black;
			this.ProdNameTb.HintForeColor = System.Drawing.Color.Empty;
			this.ProdNameTb.HintText = "";
			this.ProdNameTb.isPassword = false;
			this.ProdNameTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.ProdNameTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.ProdNameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.ProdNameTb.LineThickness = 4;
			this.ProdNameTb.Location = new System.Drawing.Point(25, 179);
			this.ProdNameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.ProdNameTb.Name = "ProdNameTb";
			this.ProdNameTb.Size = new System.Drawing.Size(216, 41);
			this.ProdNameTb.TabIndex = 22;
			this.ProdNameTb.Text = "ProductName";
			this.ProdNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.ProdNameTb.OnValueChanged += new System.EventHandler(this.ProdNameTb_OnValueChanged_1);
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
			this.QtyTb.Location = new System.Drawing.Point(25, 230);
			this.QtyTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.QtyTb.Name = "QtyTb";
			this.QtyTb.Size = new System.Drawing.Size(216, 41);
			this.QtyTb.TabIndex = 23;
			this.QtyTb.Text = "ProductQty";
			this.QtyTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// PriceTb
			// 
			this.PriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PriceTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PriceTb.ForeColor = System.Drawing.Color.Black;
			this.PriceTb.HintForeColor = System.Drawing.Color.Empty;
			this.PriceTb.HintText = "";
			this.PriceTb.isPassword = false;
			this.PriceTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.PriceTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.PriceTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.PriceTb.LineThickness = 4;
			this.PriceTb.Location = new System.Drawing.Point(25, 281);
			this.PriceTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.PriceTb.Name = "PriceTb";
			this.PriceTb.Size = new System.Drawing.Size(216, 41);
			this.PriceTb.TabIndex = 24;
			this.PriceTb.Text = "ProductPrice";
			this.PriceTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.PriceTb.OnValueChanged += new System.EventHandler(this.ProdNameTb_OnValueChanged);
			// 
			// DescriptionTb
			// 
			this.DescriptionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.DescriptionTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DescriptionTb.ForeColor = System.Drawing.Color.Black;
			this.DescriptionTb.HintForeColor = System.Drawing.Color.Empty;
			this.DescriptionTb.HintText = "";
			this.DescriptionTb.isPassword = false;
			this.DescriptionTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.DescriptionTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.DescriptionTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.DescriptionTb.LineThickness = 4;
			this.DescriptionTb.Location = new System.Drawing.Point(25, 332);
			this.DescriptionTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.DescriptionTb.Name = "DescriptionTb";
			this.DescriptionTb.Size = new System.Drawing.Size(216, 41);
			this.DescriptionTb.TabIndex = 25;
			this.DescriptionTb.Text = "Description";
			this.DescriptionTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.DescriptionTb.OnValueChanged += new System.EventHandler(this.DescriptionTb_OnValueChanged);
			// 
			// CatCombo
			// 
			this.CatCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.CatCombo.ForeColor = System.Drawing.Color.Black;
			this.CatCombo.FormattingEnabled = true;
			this.CatCombo.Location = new System.Drawing.Point(25, 381);
			this.CatCombo.Name = "CatCombo";
			this.CatCombo.Size = new System.Drawing.Size(216, 29);
			this.CatCombo.TabIndex = 26;
			this.CatCombo.Text = "Product Category";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DimGray;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(102, 466);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 30;
			this.button4.Text = "Home";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DimGray;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(192, 428);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(84, 32);
			this.button3.TabIndex = 29;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DimGray;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(102, 428);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 28;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(12, 428);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 32);
			this.button1.TabIndex = 27;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ProductsGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.ProductsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
			this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ProductsGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.ProductsGV.ColumnHeadersHeight = 25;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ProductsGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.ProductsGV.EnableHeadersVisualStyles = false;
			this.ProductsGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ProductsGV.Location = new System.Drawing.Point(300, 212);
			this.ProductsGV.Name = "ProductsGV";
			this.ProductsGV.RowHeadersVisible = false;
			this.ProductsGV.RowTemplate.Height = 30;
			this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ProductsGV.Size = new System.Drawing.Size(633, 286);
			this.ProductsGV.TabIndex = 32;
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(499, 113);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(204, 35);
			this.label4.TabIndex = 31;
			this.label4.Text = "PRODUCTS LIST";
			// 
			// SearchCombo
			// 
			this.SearchCombo.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.SearchCombo.ForeColor = System.Drawing.Color.Black;
			this.SearchCombo.FormattingEnabled = true;
			this.SearchCombo.Location = new System.Drawing.Point(499, 161);
			this.SearchCombo.Name = "SearchCombo";
			this.SearchCombo.Size = new System.Drawing.Size(216, 29);
			this.SearchCombo.TabIndex = 33;
			this.SearchCombo.Text = "Select Category";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DimGray;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.Color.Black;
			this.button5.Location = new System.Drawing.Point(712, 161);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(96, 29);
			this.button5.TabIndex = 34;
			this.button5.Text = "Search";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.DimGray;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.Color.Black;
			this.button6.Location = new System.Drawing.Point(814, 161);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(96, 29);
			this.button6.TabIndex = 35;
			this.button6.Text = "Refresh";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// ManageProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1025, 575);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.SearchCombo);
			this.Controls.Add(this.ProductsGV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.CatCombo);
			this.Controls.Add(this.DescriptionTb);
			this.Controls.Add(this.PriceTb);
			this.Controls.Add(this.QtyTb);
			this.Controls.Add(this.ProdNameTb);
			this.Controls.Add(this.ProdIdTb);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageProducts";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageProducts";
			this.Load += new System.EventHandler(this.ManageProducts_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private ns1.BunifuMaterialTextbox ProdIdTb;
		private ns1.BunifuMaterialTextbox ProdNameTb;
		private ns1.BunifuMaterialTextbox QtyTb;
		private ns1.BunifuMaterialTextbox PriceTb;
		private ns1.BunifuMaterialTextbox DescriptionTb;
		private System.Windows.Forms.ComboBox CatCombo;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private Guna.UI2.WinForms.Guna2DataGridView ProductsGV;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox SearchCombo;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
	}
}