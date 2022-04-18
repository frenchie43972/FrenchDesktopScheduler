
namespace FrenchDesktopScheduler.Forms
{
	partial class DeleteCustomer
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
			this.customerDeleteDataGridView = new System.Windows.Forms.DataGridView();
			this.toLandingButton = new System.Windows.Forms.Button();
			this.deleteCustomerButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.customerDeleteDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// customerDeleteDataGridView
			// 
			this.customerDeleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerDeleteDataGridView.Location = new System.Drawing.Point(12, 24);
			this.customerDeleteDataGridView.MultiSelect = false;
			this.customerDeleteDataGridView.Name = "customerDeleteDataGridView";
			this.customerDeleteDataGridView.ReadOnly = true;
			this.customerDeleteDataGridView.Size = new System.Drawing.Size(776, 260);
			this.customerDeleteDataGridView.TabIndex = 57;
			this.customerDeleteDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(643, 336);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 59;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// deleteCustomerButton
			// 
			this.deleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteCustomerButton.Location = new System.Drawing.Point(12, 336);
			this.deleteCustomerButton.Name = "deleteCustomerButton";
			this.deleteCustomerButton.Size = new System.Drawing.Size(145, 47);
			this.deleteCustomerButton.TabIndex = 77;
			this.deleteCustomerButton.Text = "Delete";
			this.deleteCustomerButton.UseVisualStyleBackColor = true;
			this.deleteCustomerButton.Click += new System.EventHandler(this.deleteCustomerButton_Click);
			// 
			// DeleteCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 414);
			this.Controls.Add(this.deleteCustomerButton);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.customerDeleteDataGridView);
			this.Name = "DeleteCustomer";
			this.Text = "Delete Customer";
			((System.ComponentModel.ISupportInitialize)(this.customerDeleteDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView customerDeleteDataGridView;
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.Button deleteCustomerButton;
	}
}