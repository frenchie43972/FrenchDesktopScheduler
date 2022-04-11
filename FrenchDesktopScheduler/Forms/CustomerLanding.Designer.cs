
namespace FrenchDesktopScheduler.Forms
{
	partial class CustomerLanding
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
			this.toLandingButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAddCustomer = new System.Windows.Forms.Button();
			this.btnEditCustomer = new System.Windows.Forms.Button();
			this.btnDeleteCustomer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(143, 281);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 59;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(104, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(228, 24);
			this.label1.TabIndex = 60;
			this.label1.Text = "Select Customer Action";
			// 
			// btnAddCustomer
			// 
			this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddCustomer.Location = new System.Drawing.Point(143, 63);
			this.btnAddCustomer.Name = "btnAddCustomer";
			this.btnAddCustomer.Size = new System.Drawing.Size(145, 47);
			this.btnAddCustomer.TabIndex = 61;
			this.btnAddCustomer.Text = "Add Customer";
			this.btnAddCustomer.UseVisualStyleBackColor = true;
			this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
			// 
			// btnEditCustomer
			// 
			this.btnEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditCustomer.Location = new System.Drawing.Point(143, 135);
			this.btnEditCustomer.Name = "btnEditCustomer";
			this.btnEditCustomer.Size = new System.Drawing.Size(145, 47);
			this.btnEditCustomer.TabIndex = 62;
			this.btnEditCustomer.Text = "Edit Customer";
			this.btnEditCustomer.UseVisualStyleBackColor = true;
			this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
			// 
			// btnDeleteCustomer
			// 
			this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteCustomer.Location = new System.Drawing.Point(143, 209);
			this.btnDeleteCustomer.Name = "btnDeleteCustomer";
			this.btnDeleteCustomer.Size = new System.Drawing.Size(145, 47);
			this.btnDeleteCustomer.TabIndex = 63;
			this.btnDeleteCustomer.Text = "Delete Customer";
			this.btnDeleteCustomer.UseVisualStyleBackColor = true;
			// 
			// CustomerLanding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 367);
			this.Controls.Add(this.btnDeleteCustomer);
			this.Controls.Add(this.btnEditCustomer);
			this.Controls.Add(this.btnAddCustomer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.toLandingButton);
			this.Name = "CustomerLanding";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CustomerLanding";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAddCustomer;
		private System.Windows.Forms.Button btnEditCustomer;
		private System.Windows.Forms.Button btnDeleteCustomer;
	}
}