
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
			this.customerDataGridView = new System.Windows.Forms.DataGridView();
			this.editCustomerButton = new System.Windows.Forms.Button();
			this.deleteCustomerButton = new System.Windows.Forms.Button();
			this.toLandingButton = new System.Windows.Forms.Button();
			this.custPhoneTextBox = new System.Windows.Forms.TextBox();
			this.custCountryTextBox = new System.Windows.Forms.TextBox();
			this.custPostTextBox = new System.Windows.Forms.TextBox();
			this.custCityTextBox = new System.Windows.Forms.TextBox();
			this.custAdd2TextBox = new System.Windows.Forms.TextBox();
			this.custAddTextBox = new System.Windows.Forms.TextBox();
			this.custNameTextBox = new System.Windows.Forms.TextBox();
			this.custIDTextBox = new System.Windows.Forms.TextBox();
			this.custAddressTwoLabel = new System.Windows.Forms.Label();
			this.customerCountryLabel = new System.Windows.Forms.Label();
			this.customerCityLabel = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.customerPhoneLabel = new System.Windows.Forms.Label();
			this.customerAddressLabel = new System.Windows.Forms.Label();
			this.customerNameLabel = new System.Windows.Forms.Label();
			this.customerIDLabel = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.saveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
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
			// customerDataGridView
			// 
			this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerDataGridView.Location = new System.Drawing.Point(26, 52);
			this.customerDataGridView.MultiSelect = false;
			this.customerDataGridView.Name = "customerDataGridView";
			this.customerDataGridView.ReadOnly = true;
			this.customerDataGridView.Size = new System.Drawing.Size(524, 184);
			this.customerDataGridView.TabIndex = 2;
			this.customerDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.myBindingComplete);
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
			this.toLandingButton.Location = new System.Drawing.Point(620, 399);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 5;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// custPhoneTextBox
			// 
			this.custPhoneTextBox.Location = new System.Drawing.Point(356, 414);
			this.custPhoneTextBox.Name = "custPhoneTextBox";
			this.custPhoneTextBox.Size = new System.Drawing.Size(110, 20);
			this.custPhoneTextBox.TabIndex = 52;
			this.custPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custPhoneTextBox_KeyPress);
			// 
			// custCountryTextBox
			// 
			this.custCountryTextBox.Location = new System.Drawing.Point(117, 414);
			this.custCountryTextBox.Name = "custCountryTextBox";
			this.custCountryTextBox.Size = new System.Drawing.Size(146, 20);
			this.custCountryTextBox.TabIndex = 51;
			// 
			// custPostTextBox
			// 
			this.custPostTextBox.Location = new System.Drawing.Point(356, 372);
			this.custPostTextBox.Name = "custPostTextBox";
			this.custPostTextBox.Size = new System.Drawing.Size(110, 20);
			this.custPostTextBox.TabIndex = 50;
			this.custPostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custPostTextBox_KeyPress);
			// 
			// custCityTextBox
			// 
			this.custCityTextBox.Location = new System.Drawing.Point(117, 372);
			this.custCityTextBox.Name = "custCityTextBox";
			this.custCityTextBox.Size = new System.Drawing.Size(146, 20);
			this.custCityTextBox.TabIndex = 49;
			// 
			// custAdd2TextBox
			// 
			this.custAdd2TextBox.Location = new System.Drawing.Point(117, 328);
			this.custAdd2TextBox.Name = "custAdd2TextBox";
			this.custAdd2TextBox.Size = new System.Drawing.Size(349, 20);
			this.custAdd2TextBox.TabIndex = 48;
			// 
			// custAddTextBox
			// 
			this.custAddTextBox.Location = new System.Drawing.Point(117, 283);
			this.custAddTextBox.Name = "custAddTextBox";
			this.custAddTextBox.Size = new System.Drawing.Size(349, 20);
			this.custAddTextBox.TabIndex = 47;
			// 
			// custNameTextBox
			// 
			this.custNameTextBox.Location = new System.Drawing.Point(320, 242);
			this.custNameTextBox.Name = "custNameTextBox";
			this.custNameTextBox.Size = new System.Drawing.Size(146, 20);
			this.custNameTextBox.TabIndex = 46;
			// 
			// custIDTextBox
			// 
			this.custIDTextBox.Location = new System.Drawing.Point(117, 242);
			this.custIDTextBox.Name = "custIDTextBox";
			this.custIDTextBox.ReadOnly = true;
			this.custIDTextBox.Size = new System.Drawing.Size(59, 20);
			this.custIDTextBox.TabIndex = 45;
			// 
			// custAddressTwoLabel
			// 
			this.custAddressTwoLabel.AutoSize = true;
			this.custAddressTwoLabel.Location = new System.Drawing.Point(28, 331);
			this.custAddressTwoLabel.Name = "custAddressTwoLabel";
			this.custAddressTwoLabel.Size = new System.Drawing.Size(54, 13);
			this.custAddressTwoLabel.TabIndex = 44;
			this.custAddressTwoLabel.Text = "Address 2";
			// 
			// customerCountryLabel
			// 
			this.customerCountryLabel.AutoSize = true;
			this.customerCountryLabel.Location = new System.Drawing.Point(28, 417);
			this.customerCountryLabel.Name = "customerCountryLabel";
			this.customerCountryLabel.Size = new System.Drawing.Size(43, 13);
			this.customerCountryLabel.TabIndex = 43;
			this.customerCountryLabel.Text = "Country";
			// 
			// customerCityLabel
			// 
			this.customerCityLabel.AutoSize = true;
			this.customerCityLabel.Location = new System.Drawing.Point(28, 375);
			this.customerCityLabel.Name = "customerCityLabel";
			this.customerCityLabel.Size = new System.Drawing.Size(24, 13);
			this.customerCityLabel.TabIndex = 42;
			this.customerCityLabel.Text = "City";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(269, 375);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 41;
			this.label5.Text = "Postal Code";
			// 
			// customerPhoneLabel
			// 
			this.customerPhoneLabel.AutoSize = true;
			this.customerPhoneLabel.Location = new System.Drawing.Point(269, 417);
			this.customerPhoneLabel.Name = "customerPhoneLabel";
			this.customerPhoneLabel.Size = new System.Drawing.Size(78, 13);
			this.customerPhoneLabel.TabIndex = 40;
			this.customerPhoneLabel.Text = "Phone Number";
			// 
			// customerAddressLabel
			// 
			this.customerAddressLabel.AutoSize = true;
			this.customerAddressLabel.Location = new System.Drawing.Point(28, 286);
			this.customerAddressLabel.Name = "customerAddressLabel";
			this.customerAddressLabel.Size = new System.Drawing.Size(45, 13);
			this.customerAddressLabel.TabIndex = 39;
			this.customerAddressLabel.Text = "Address";
			// 
			// customerNameLabel
			// 
			this.customerNameLabel.AutoSize = true;
			this.customerNameLabel.Location = new System.Drawing.Point(223, 245);
			this.customerNameLabel.Name = "customerNameLabel";
			this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
			this.customerNameLabel.TabIndex = 38;
			this.customerNameLabel.Text = "Customer Name";
			// 
			// customerIDLabel
			// 
			this.customerIDLabel.AutoSize = true;
			this.customerIDLabel.Location = new System.Drawing.Point(28, 245);
			this.customerIDLabel.Name = "customerIDLabel";
			this.customerIDLabel.Size = new System.Drawing.Size(65, 13);
			this.customerIDLabel.TabIndex = 37;
			this.customerIDLabel.Text = "Customer ID";
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(620, 256);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(145, 47);
			this.cancelButton.TabIndex = 53;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(620, 328);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(145, 47);
			this.saveButton.TabIndex = 54;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// Customer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 460);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.custPhoneTextBox);
			this.Controls.Add(this.custCountryTextBox);
			this.Controls.Add(this.custPostTextBox);
			this.Controls.Add(this.custCityTextBox);
			this.Controls.Add(this.custAdd2TextBox);
			this.Controls.Add(this.custAddTextBox);
			this.Controls.Add(this.custNameTextBox);
			this.Controls.Add(this.custIDTextBox);
			this.Controls.Add(this.custAddressTwoLabel);
			this.Controls.Add(this.customerCountryLabel);
			this.Controls.Add(this.customerCityLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.customerPhoneLabel);
			this.Controls.Add(this.customerAddressLabel);
			this.Controls.Add(this.customerNameLabel);
			this.Controls.Add(this.customerIDLabel);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.deleteCustomerButton);
			this.Controls.Add(this.editCustomerButton);
			this.Controls.Add(this.customerDataGridView);
			this.Controls.Add(this.addCustomerButton);
			this.Controls.Add(this.customerPageLabel);
			this.Name = "Customer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customer";
			((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label customerPageLabel;
		private System.Windows.Forms.Button addCustomerButton;
		private System.Windows.Forms.DataGridView customerDataGridView;
		private System.Windows.Forms.Button editCustomerButton;
		private System.Windows.Forms.Button deleteCustomerButton;
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.TextBox custPhoneTextBox;
		private System.Windows.Forms.TextBox custCountryTextBox;
		private System.Windows.Forms.TextBox custPostTextBox;
		private System.Windows.Forms.TextBox custCityTextBox;
		private System.Windows.Forms.TextBox custAdd2TextBox;
		private System.Windows.Forms.TextBox custAddTextBox;
		private System.Windows.Forms.TextBox custNameTextBox;
		private System.Windows.Forms.TextBox custIDTextBox;
		private System.Windows.Forms.Label custAddressTwoLabel;
		private System.Windows.Forms.Label customerCountryLabel;
		private System.Windows.Forms.Label customerCityLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label customerPhoneLabel;
		private System.Windows.Forms.Label customerAddressLabel;
		private System.Windows.Forms.Label customerNameLabel;
		private System.Windows.Forms.Label customerIDLabel;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button saveButton;
	}
}