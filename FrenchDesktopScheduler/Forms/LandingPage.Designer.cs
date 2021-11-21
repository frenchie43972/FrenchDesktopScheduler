
namespace FrenchDesktopScheduler.Forms
{
	partial class LandingPage
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
			this.langinPageLabel = new System.Windows.Forms.Label();
			this.customerButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.loginBackButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// langinPageLabel
			// 
			this.langinPageLabel.AutoSize = true;
			this.langinPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.langinPageLabel.Location = new System.Drawing.Point(99, 20);
			this.langinPageLabel.Name = "langinPageLabel";
			this.langinPageLabel.Size = new System.Drawing.Size(255, 24);
			this.langinPageLabel.TabIndex = 0;
			this.langinPageLabel.Text = "Please Select Your Option";
			// 
			// customerButton
			// 
			this.customerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerButton.Location = new System.Drawing.Point(181, 67);
			this.customerButton.MinimumSize = new System.Drawing.Size(85, 30);
			this.customerButton.Name = "customerButton";
			this.customerButton.Size = new System.Drawing.Size(85, 30);
			this.customerButton.TabIndex = 1;
			this.customerButton.Text = "Customers";
			this.customerButton.UseVisualStyleBackColor = true;
			this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(181, 128);
			this.button2.MinimumSize = new System.Drawing.Size(85, 30);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 30);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(181, 192);
			this.button3.MinimumSize = new System.Drawing.Size(85, 30);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 30);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// loginBackButton
			// 
			this.loginBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginBackButton.Location = new System.Drawing.Point(103, 283);
			this.loginBackButton.MinimumSize = new System.Drawing.Size(85, 30);
			this.loginBackButton.Name = "loginBackButton";
			this.loginBackButton.Size = new System.Drawing.Size(251, 31);
			this.loginBackButton.TabIndex = 4;
			this.loginBackButton.Text = "Back to Login\r\n";
			this.loginBackButton.UseVisualStyleBackColor = true;
			this.loginBackButton.Click += new System.EventHandler(this.loginBackButton_Click);
			// 
			// LandingPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 367);
			this.Controls.Add(this.loginBackButton);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.customerButton);
			this.Controls.Add(this.langinPageLabel);
			this.Name = "LandingPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Landing Page";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label langinPageLabel;
		private System.Windows.Forms.Button customerButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button loginBackButton;
	}
}