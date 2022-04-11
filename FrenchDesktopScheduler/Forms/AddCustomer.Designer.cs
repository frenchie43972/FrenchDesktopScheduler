
namespace FrenchDesktopScheduler.Forms
{
	partial class AddCustomer
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
			this.saveButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
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
			this.toLandingButton = new System.Windows.Forms.Button();
			this.customerAddDataGridView = new System.Windows.Forms.DataGridView();
			this.addCustomerButton = new System.Windows.Forms.Button();
			this.customerPageLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customerAddDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saveButton.Location = new System.Drawing.Point(625, 281);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(145, 47);
			this.saveButton.TabIndex = 76;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cancelButton.Location = new System.Drawing.Point(625, 168);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(145, 47);
			this.cancelButton.TabIndex = 75;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// custPhoneTextBox
			// 
			this.custPhoneTextBox.Location = new System.Drawing.Point(361, 412);
			this.custPhoneTextBox.Name = "custPhoneTextBox";
			this.custPhoneTextBox.Size = new System.Drawing.Size(110, 20);
			this.custPhoneTextBox.TabIndex = 74;
			this.custPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custPhoneTextBox_KeyPress);
			// 
			// custCountryTextBox
			// 
			this.custCountryTextBox.Location = new System.Drawing.Point(122, 412);
			this.custCountryTextBox.Name = "custCountryTextBox";
			this.custCountryTextBox.Size = new System.Drawing.Size(146, 20);
			this.custCountryTextBox.TabIndex = 73;
			// 
			// custPostTextBox
			// 
			this.custPostTextBox.Location = new System.Drawing.Point(361, 370);
			this.custPostTextBox.Name = "custPostTextBox";
			this.custPostTextBox.Size = new System.Drawing.Size(110, 20);
			this.custPostTextBox.TabIndex = 72;
			this.custPostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.custPostTextBox_KeyPress);
			// 
			// custCityTextBox
			// 
			this.custCityTextBox.Location = new System.Drawing.Point(122, 370);
			this.custCityTextBox.Name = "custCityTextBox";
			this.custCityTextBox.Size = new System.Drawing.Size(146, 20);
			this.custCityTextBox.TabIndex = 71;
			// 
			// custAdd2TextBox
			// 
			this.custAdd2TextBox.Location = new System.Drawing.Point(122, 326);
			this.custAdd2TextBox.Name = "custAdd2TextBox";
			this.custAdd2TextBox.Size = new System.Drawing.Size(349, 20);
			this.custAdd2TextBox.TabIndex = 70;
			// 
			// custAddTextBox
			// 
			this.custAddTextBox.Location = new System.Drawing.Point(122, 281);
			this.custAddTextBox.Name = "custAddTextBox";
			this.custAddTextBox.Size = new System.Drawing.Size(349, 20);
			this.custAddTextBox.TabIndex = 69;
			// 
			// custNameTextBox
			// 
			this.custNameTextBox.Location = new System.Drawing.Point(325, 240);
			this.custNameTextBox.Name = "custNameTextBox";
			this.custNameTextBox.Size = new System.Drawing.Size(146, 20);
			this.custNameTextBox.TabIndex = 68;
			// 
			// custIDTextBox
			// 
			this.custIDTextBox.Location = new System.Drawing.Point(122, 240);
			this.custIDTextBox.Name = "custIDTextBox";
			this.custIDTextBox.ReadOnly = true;
			this.custIDTextBox.Size = new System.Drawing.Size(59, 20);
			this.custIDTextBox.TabIndex = 67;
			// 
			// custAddressTwoLabel
			// 
			this.custAddressTwoLabel.AutoSize = true;
			this.custAddressTwoLabel.Location = new System.Drawing.Point(33, 329);
			this.custAddressTwoLabel.Name = "custAddressTwoLabel";
			this.custAddressTwoLabel.Size = new System.Drawing.Size(54, 13);
			this.custAddressTwoLabel.TabIndex = 66;
			this.custAddressTwoLabel.Text = "Address 2";
			// 
			// customerCountryLabel
			// 
			this.customerCountryLabel.AutoSize = true;
			this.customerCountryLabel.Location = new System.Drawing.Point(33, 415);
			this.customerCountryLabel.Name = "customerCountryLabel";
			this.customerCountryLabel.Size = new System.Drawing.Size(43, 13);
			this.customerCountryLabel.TabIndex = 65;
			this.customerCountryLabel.Text = "Country";
			// 
			// customerCityLabel
			// 
			this.customerCityLabel.AutoSize = true;
			this.customerCityLabel.Location = new System.Drawing.Point(33, 373);
			this.customerCityLabel.Name = "customerCityLabel";
			this.customerCityLabel.Size = new System.Drawing.Size(24, 13);
			this.customerCityLabel.TabIndex = 64;
			this.customerCityLabel.Text = "City";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(274, 373);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(64, 13);
			this.label5.TabIndex = 63;
			this.label5.Text = "Postal Code";
			// 
			// customerPhoneLabel
			// 
			this.customerPhoneLabel.AutoSize = true;
			this.customerPhoneLabel.Location = new System.Drawing.Point(274, 415);
			this.customerPhoneLabel.Name = "customerPhoneLabel";
			this.customerPhoneLabel.Size = new System.Drawing.Size(78, 13);
			this.customerPhoneLabel.TabIndex = 62;
			this.customerPhoneLabel.Text = "Phone Number";
			// 
			// customerAddressLabel
			// 
			this.customerAddressLabel.AutoSize = true;
			this.customerAddressLabel.Location = new System.Drawing.Point(33, 284);
			this.customerAddressLabel.Name = "customerAddressLabel";
			this.customerAddressLabel.Size = new System.Drawing.Size(45, 13);
			this.customerAddressLabel.TabIndex = 61;
			this.customerAddressLabel.Text = "Address";
			// 
			// customerNameLabel
			// 
			this.customerNameLabel.AutoSize = true;
			this.customerNameLabel.Location = new System.Drawing.Point(228, 243);
			this.customerNameLabel.Name = "customerNameLabel";
			this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
			this.customerNameLabel.TabIndex = 60;
			this.customerNameLabel.Text = "Customer Name";
			// 
			// customerIDLabel
			// 
			this.customerIDLabel.AutoSize = true;
			this.customerIDLabel.Location = new System.Drawing.Point(33, 243);
			this.customerIDLabel.Name = "customerIDLabel";
			this.customerIDLabel.Size = new System.Drawing.Size(65, 13);
			this.customerIDLabel.TabIndex = 59;
			this.customerIDLabel.Text = "Customer ID";
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(625, 385);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 58;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// customerAddDataGridView
			// 
			this.customerAddDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerAddDataGridView.Location = new System.Drawing.Point(31, 50);
			this.customerAddDataGridView.MultiSelect = false;
			this.customerAddDataGridView.Name = "customerAddDataGridView";
			this.customerAddDataGridView.ReadOnly = true;
			this.customerAddDataGridView.Size = new System.Drawing.Size(524, 184);
			this.customerAddDataGridView.TabIndex = 57;
			// 
			// addCustomerButton
			// 
			this.addCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addCustomerButton.Location = new System.Drawing.Point(625, 50);
			this.addCustomerButton.Name = "addCustomerButton";
			this.addCustomerButton.Size = new System.Drawing.Size(145, 47);
			this.addCustomerButton.TabIndex = 56;
			this.addCustomerButton.Text = "Add";
			this.addCustomerButton.UseVisualStyleBackColor = true;
			this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
			// 
			// customerPageLabel
			// 
			this.customerPageLabel.AutoSize = true;
			this.customerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerPageLabel.Location = new System.Drawing.Point(260, 7);
			this.customerPageLabel.Name = "customerPageLabel";
			this.customerPageLabel.Size = new System.Drawing.Size(295, 31);
			this.customerPageLabel.TabIndex = 55;
			this.customerPageLabel.Text = "Customer Information";
			// 
			// AddCustomer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
			this.Controls.Add(this.customerAddDataGridView);
			this.Controls.Add(this.addCustomerButton);
			this.Controls.Add(this.customerPageLabel);
			this.Name = "AddCustomer";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddCustomer";
			((System.ComponentModel.ISupportInitialize)(this.customerAddDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button cancelButton;
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
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.DataGridView customerAddDataGridView;
		private System.Windows.Forms.Button addCustomerButton;
		private System.Windows.Forms.Label customerPageLabel;
	}
}