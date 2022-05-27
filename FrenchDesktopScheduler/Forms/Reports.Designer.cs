
namespace FrenchDesktopScheduler.Forms
{
	partial class Reports
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
			this.label1 = new System.Windows.Forms.Label();
			this.toLandingButton = new System.Windows.Forms.Button();
			this.monthNumApptButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(100, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Reports";
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(73, 361);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 61;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// monthNumApptButton
			// 
			this.monthNumApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthNumApptButton.Location = new System.Drawing.Point(73, 71);
			this.monthNumApptButton.Name = "monthNumApptButton";
			this.monthNumApptButton.Size = new System.Drawing.Size(145, 47);
			this.monthNumApptButton.TabIndex = 62;
			this.monthNumApptButton.Text = "Number of Monthly Appointments";
			this.monthNumApptButton.UseVisualStyleBackColor = true;
			this.monthNumApptButton.Click += new System.EventHandler(this.monthNumApptButton_Click);
			// 
			// Reports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(288, 450);
			this.Controls.Add(this.monthNumApptButton);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "Reports";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reports";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.Button monthNumApptButton;
	}
}