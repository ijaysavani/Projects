namespace FeniImpex
{
	partial class SplashForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.progress = new ns1.BunifuCircleProgressbar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(203, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(210, 44);
			this.label1.TabIndex = 1;
			this.label1.Text = "FENI IMPEX";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(532, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(109, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Version 1.0";
			// 
			// progress
			// 
			this.progress.animated = false;
			this.progress.animationIterval = 5;
			this.progress.animationSpeed = 300;
			this.progress.BackColor = System.Drawing.Color.Transparent;
			this.progress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progress.BackgroundImage")));
			this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
			this.progress.ForeColor = System.Drawing.Color.Black;
			this.progress.LabelVisible = true;
			this.progress.LineProgressThickness = 8;
			this.progress.LineThickness = 20;
			this.progress.Location = new System.Drawing.Point(212, 64);
			this.progress.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.progress.MaxValue = 100;
			this.progress.Name = "progress";
			this.progress.ProgressBackColor = System.Drawing.Color.Gainsboro;
			this.progress.ProgressColor = System.Drawing.Color.SeaGreen;
			this.progress.Size = new System.Drawing.Size(201, 201);
			this.progress.TabIndex = 3;
			this.progress.Value = 0;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// SplashForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(642, 283);
			this.Controls.Add(this.progress);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SplashForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SplashForm";
			this.Load += new System.EventHandler(this.SplashForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private ns1.BunifuCircleProgressbar progress;
		private System.Windows.Forms.Timer timer1;
	}
}