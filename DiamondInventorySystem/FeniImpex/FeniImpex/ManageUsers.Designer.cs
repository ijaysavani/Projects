namespace FeniImpex
{
	partial class ManageUsers
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
			this.unameTb = new ns1.BunifuMaterialTextbox();
			this.FnameTb = new ns1.BunifuMaterialTextbox();
			this.PasswordTb = new ns1.BunifuMaterialTextbox();
			this.PhoneTb = new ns1.BunifuMaterialTextbox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.UsersGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
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
			this.panel1.TabIndex = 0;
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
			this.label2.Location = new System.Drawing.Point(351, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(198, 33);
			this.label2.TabIndex = 1;
			this.label2.Text = "Manage Users";
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
			// unameTb
			// 
			this.unameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.unameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.unameTb.ForeColor = System.Drawing.Color.Black;
			this.unameTb.HintForeColor = System.Drawing.Color.Empty;
			this.unameTb.HintText = "";
			this.unameTb.isPassword = false;
			this.unameTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.unameTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.unameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.unameTb.LineThickness = 4;
			this.unameTb.Location = new System.Drawing.Point(14, 129);
			this.unameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.unameTb.Name = "unameTb";
			this.unameTb.Size = new System.Drawing.Size(216, 41);
			this.unameTb.TabIndex = 1;
			this.unameTb.Text = "UserName";
			this.unameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.unameTb.OnValueChanged += new System.EventHandler(this.unameTb_OnValueChanged);
			// 
			// FnameTb
			// 
			this.FnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.FnameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FnameTb.ForeColor = System.Drawing.Color.Black;
			this.FnameTb.HintForeColor = System.Drawing.Color.Empty;
			this.FnameTb.HintText = "";
			this.FnameTb.isPassword = false;
			this.FnameTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.FnameTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.FnameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.FnameTb.LineThickness = 4;
			this.FnameTb.Location = new System.Drawing.Point(14, 180);
			this.FnameTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.FnameTb.Name = "FnameTb";
			this.FnameTb.Size = new System.Drawing.Size(216, 41);
			this.FnameTb.TabIndex = 2;
			this.FnameTb.Text = "FullName";
			this.FnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.FnameTb.OnValueChanged += new System.EventHandler(this.FnameTb_OnValueChanged);
			// 
			// PasswordTb
			// 
			this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PasswordTb.ForeColor = System.Drawing.Color.Black;
			this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
			this.PasswordTb.HintText = "";
			this.PasswordTb.isPassword = false;
			this.PasswordTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.PasswordTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.PasswordTb.LineThickness = 4;
			this.PasswordTb.Location = new System.Drawing.Point(14, 231);
			this.PasswordTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.PasswordTb.Name = "PasswordTb";
			this.PasswordTb.Size = new System.Drawing.Size(216, 41);
			this.PasswordTb.TabIndex = 3;
			this.PasswordTb.Text = "Password";
			this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			this.PasswordTb.OnValueChanged += new System.EventHandler(this.PasswordTb_OnValueChanged);
			// 
			// PhoneTb
			// 
			this.PhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PhoneTb.ForeColor = System.Drawing.Color.Black;
			this.PhoneTb.HintForeColor = System.Drawing.Color.Empty;
			this.PhoneTb.HintText = "";
			this.PhoneTb.isPassword = false;
			this.PhoneTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.PhoneTb.LineIdleColor = System.Drawing.Color.Maroon;
			this.PhoneTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.PhoneTb.LineThickness = 4;
			this.PhoneTb.Location = new System.Drawing.Point(14, 282);
			this.PhoneTb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.PhoneTb.Name = "PhoneTb";
			this.PhoneTb.Size = new System.Drawing.Size(216, 41);
			this.PhoneTb.TabIndex = 4;
			this.PhoneTb.Text = "Telephone";
			this.PhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(14, 331);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(84, 32);
			this.button1.TabIndex = 5;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DimGray;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(104, 331);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(84, 32);
			this.button2.TabIndex = 6;
			this.button2.Text = "Edit";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DimGray;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(194, 331);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(84, 32);
			this.button3.TabIndex = 7;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DimGray;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(104, 369);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(84, 32);
			this.button4.TabIndex = 8;
			this.button4.Text = "Home";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.DimGray;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 688);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(956, 12);
			this.panel2.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label4.Location = new System.Drawing.Point(578, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(139, 35);
			this.label4.TabIndex = 11;
			this.label4.Text = "USERS LIST";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// UsersGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.UsersGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.UsersGV.BackgroundColor = System.Drawing.Color.White;
			this.UsersGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.UsersGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.UsersGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.UsersGV.ColumnHeadersHeight = 25;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.UsersGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.UsersGV.EnableHeadersVisualStyles = false;
			this.UsersGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.UsersGV.Location = new System.Drawing.Point(399, 180);
			this.UsersGV.Name = "UsersGV";
			this.UsersGV.RowHeadersVisible = false;
			this.UsersGV.RowTemplate.Height = 30;
			this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.UsersGV.Size = new System.Drawing.Size(529, 502);
			this.UsersGV.TabIndex = 12;
			this.UsersGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
			this.UsersGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.UsersGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.UsersGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.UsersGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.UsersGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.UsersGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.UsersGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Black;
			this.UsersGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.UsersGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UsersGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.UsersGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.UsersGV.ThemeStyle.HeaderStyle.Height = 25;
			this.UsersGV.ThemeStyle.ReadOnly = false;
			this.UsersGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.UsersGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
			this.UsersGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
			this.UsersGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.UsersGV.ThemeStyle.RowsStyle.Height = 30;
			this.UsersGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.UsersGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.UsersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellContentClick_1);
			// 
			// ManageUsers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(956, 700);
			this.Controls.Add(this.UsersGV);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.PhoneTb);
			this.Controls.Add(this.PasswordTb);
			this.Controls.Add(this.FnameTb);
			this.Controls.Add(this.unameTb);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ManageUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ManageUsers";
			this.Load += new System.EventHandler(this.ManageUsers_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ns1.BunifuMaterialTextbox unameTb;
		private System.Windows.Forms.Label label3;
		private ns1.BunifuMaterialTextbox FnameTb;
		private ns1.BunifuMaterialTextbox PasswordTb;
		private ns1.BunifuMaterialTextbox PhoneTb;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2DataGridView UsersGV;
	}
}