﻿namespace FeniImpex
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.PasswordTb = new ns1.BunifuMaterialTextbox();
			this.UnameTb = new ns1.BunifuMaterialTextbox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightGray;
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.checkBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.PasswordTb);
			this.panel1.Controls.Add(this.UnameTb);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(142, 69);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(242, 332);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.ErrorImage = null;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(62, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.ForeColor = System.Drawing.Color.Blue;
			this.checkBox1.Location = new System.Drawing.Point(90, 264);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(120, 20);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "ShowPassword";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(33, 264);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Clear";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.DimGray;
			this.button1.Location = new System.Drawing.Point(32, 207);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 40);
			this.button1.TabIndex = 3;
			this.button1.Text = "Login";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// PasswordTb
			// 
			this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.PasswordTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.PasswordTb.ForeColor = System.Drawing.Color.Black;
			this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
			this.PasswordTb.HintText = "";
			this.PasswordTb.isPassword = true;
			this.PasswordTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.PasswordTb.LineIdleColor = System.Drawing.Color.DimGray;
			this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.PasswordTb.LineThickness = 3;
			this.PasswordTb.Location = new System.Drawing.Point(33, 150);
			this.PasswordTb.Margin = new System.Windows.Forms.Padding(4);
			this.PasswordTb.Name = "PasswordTb";
			this.PasswordTb.Size = new System.Drawing.Size(177, 33);
			this.PasswordTb.TabIndex = 2;
			this.PasswordTb.Text = "Password";
			this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// UnameTb
			// 
			this.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.UnameTb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
			this.UnameTb.ForeColor = System.Drawing.Color.Black;
			this.UnameTb.HintForeColor = System.Drawing.Color.Empty;
			this.UnameTb.HintText = "";
			this.UnameTb.isPassword = false;
			this.UnameTb.LineFocusedColor = System.Drawing.Color.Blue;
			this.UnameTb.LineIdleColor = System.Drawing.Color.DimGray;
			this.UnameTb.LineMouseHoverColor = System.Drawing.Color.Blue;
			this.UnameTb.LineThickness = 3;
			this.UnameTb.Location = new System.Drawing.Point(32, 99);
			this.UnameTb.Margin = new System.Windows.Forms.Padding(4);
			this.UnameTb.Name = "UnameTb";
			this.UnameTb.Size = new System.Drawing.Size(177, 33);
			this.UnameTb.TabIndex = 1;
			this.UnameTb.Text = "UserName";
			this.UnameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DimGray;
			this.label1.Location = new System.Drawing.Point(85, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.LightPink;
			this.label2.Location = new System.Drawing.Point(199, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(143, 30);
			this.label2.TabIndex = 1;
			this.label2.Text = "FENI IMPEX®";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(483, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 33);
			this.label4.TabIndex = 3;
			this.label4.Text = "X";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(514, 471);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ns1.BunifuMaterialTextbox UnameTb;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private ns1.BunifuMaterialTextbox PasswordTb;
		private System.Windows.Forms.Label label4;
	}
}

