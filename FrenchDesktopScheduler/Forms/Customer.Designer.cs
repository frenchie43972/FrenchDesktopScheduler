
namespace FrenchDesktopScheduler.Forms
{
	partial class Customer
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
			this.customerPageLabel = new System.Windows.Forms.Label();
			this.addCustomerButton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.editCustomerButton = new System.Windows.Forms.Button();
			this.deleteCustomerButton = new System.Windows.Forms.Button();
			this.toLandingButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// customerPageLabel
			// 
			this.customerPageLabel.AutoSize = true;
			this.customerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerPageLabel.Location = new System.Drawing.Point(255, 9);
			this.customerPageLabel.Name = "customerPageLabel";
			this.customerPageLabel.Size = new System.Drawing.Size(295, 31);
			this.customerPageLabel.TabIndex = 0;
			this.customerPageLabel.Text = "Customer Information";
			// 
			// addCustomerButton
			// 
			this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCustomerButton.Location = new System.Drawing.Point(620, 52);
			this.addCustomerButton.Name = "addCustomerButton";
			this.addCustomerButton.Size = new System.Drawing.Size(145, 47);
			this.addCustomerButton.TabIndex = 1;
			this.addCustomerButton.Text = "Add";
			this.addCustomerButton.UseVisualStyleBackColor = true;
			this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(26, 52);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(524, 184);
			this.dataGridView1.TabIndex = 2;
			// 
			// editCustomerButton
			// 
			this.editCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editCustomerButton.Location = new System.Drawing.Point(620, 121);
			this.editCustomerButton.Name = "editCustomerButton";
			this.editCustomerButton.Size = new System.Drawing.Size(145, 47);
			this.editCustomerButton.TabIndex = 3;
			this.editCustomerButton.Text = "Edit";
			this.editCustomerButton.UseVisualStyleBackColor = true;
			this.editCustomerButton.Click += new System.EventHandler(this.editCustomerButton_Click);
			// 
			// deleteCustomerButton
			// 
			this.deleteCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.deleteCustomerButton.Location = new System.Drawing.Point(620, 189);
			this.deleteCustomerButton.Name = "deleteCustomerButton";
			this.deleteCustomerButton.Size = new System.Drawing.Size(145, 47);
			this.deleteCustomerButton.TabIndex = 4;
			this.deleteCustomerButton.Text = "Delete";
			this.deleteCustomerButton.UseVisualStyleBackColor = true;
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(620, 295);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 5;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 384);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.deleteCustomerButton);
			this.Controls.Add(this.editCustomerButton);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addCustomerButton);
			this.Controls.Add(this.customerPageLabel);
			this.Name = "Customer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label customerPageLabel;
		private System.Windows.Forms.Button addCustomerButton;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button editCustomerButton;
		private System.Windows.Forms.Button deleteCustomerButton;
		private System.Windows.Forms.Button toLandingButton;
	}
}