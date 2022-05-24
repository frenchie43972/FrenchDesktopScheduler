
namespace FrenchDesktopScheduler.Forms
{
	partial class EditAppointment
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
			this.apptCancelButton = new System.Windows.Forms.Button();
			this.editApptSaveButton = new System.Windows.Forms.Button();
			this.toLandingButton = new System.Windows.Forms.Button();
			this.editApptEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.editApptStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.editApptComboBox = new System.Windows.Forms.ComboBox();
			this.editApptCustComboBox = new System.Windows.Forms.ComboBox();
			this.endLabel = new System.Windows.Forms.Label();
			this.startLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.customerLabel = new System.Windows.Forms.Label();
			this.customerPageLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.editApptIDComboBox = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// apptCancelButton
			// 
			this.apptCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apptCancelButton.Location = new System.Drawing.Point(113, 366);
			this.apptCancelButton.Name = "apptCancelButton";
			this.apptCancelButton.Size = new System.Drawing.Size(145, 47);
			this.apptCancelButton.TabIndex = 84;
			this.apptCancelButton.Text = "Cancel";
			this.apptCancelButton.UseVisualStyleBackColor = true;
			this.apptCancelButton.Click += new System.EventHandler(this.apptCancelButton_Click);
			// 
			// editApptSaveButton
			// 
			this.editApptSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.editApptSaveButton.Location = new System.Drawing.Point(14, 297);
			this.editApptSaveButton.Name = "editApptSaveButton";
			this.editApptSaveButton.Size = new System.Drawing.Size(145, 47);
			this.editApptSaveButton.TabIndex = 83;
			this.editApptSaveButton.Text = "Save";
			this.editApptSaveButton.UseVisualStyleBackColor = true;
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(219, 297);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 82;
			this.toLandingButton.Text = "To Appointment Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// editApptEndDateTimePicker
			// 
			this.editApptEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.editApptEndDateTimePicker.Location = new System.Drawing.Point(97, 249);
			this.editApptEndDateTimePicker.Name = "editApptEndDateTimePicker";
			this.editApptEndDateTimePicker.Size = new System.Drawing.Size(265, 20);
			this.editApptEndDateTimePicker.TabIndex = 81;
			// 
			// editApptStartDateTimePicker
			// 
			this.editApptStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.editApptStartDateTimePicker.Location = new System.Drawing.Point(97, 199);
			this.editApptStartDateTimePicker.Name = "editApptStartDateTimePicker";
			this.editApptStartDateTimePicker.Size = new System.Drawing.Size(265, 20);
			this.editApptStartDateTimePicker.TabIndex = 80;
			// 
			// editApptComboBox
			// 
			this.editApptComboBox.FormattingEnabled = true;
			this.editApptComboBox.Location = new System.Drawing.Point(98, 143);
			this.editApptComboBox.Name = "editApptComboBox";
			this.editApptComboBox.Size = new System.Drawing.Size(266, 21);
			this.editApptComboBox.TabIndex = 79;
			// 
			// editApptCustComboBox
			// 
			this.editApptCustComboBox.FormattingEnabled = true;
			this.editApptCustComboBox.Location = new System.Drawing.Point(97, 92);
			this.editApptCustComboBox.Name = "editApptCustComboBox";
			this.editApptCustComboBox.Size = new System.Drawing.Size(265, 21);
			this.editApptCustComboBox.TabIndex = 78;
			// 
			// endLabel
			// 
			this.endLabel.AutoSize = true;
			this.endLabel.Location = new System.Drawing.Point(17, 255);
			this.endLabel.Name = "endLabel";
			this.endLabel.Size = new System.Drawing.Size(26, 13);
			this.endLabel.TabIndex = 77;
			this.endLabel.Text = "End";
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(17, 205);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(29, 13);
			this.startLabel.TabIndex = 76;
			this.startLabel.Text = "Start";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(17, 150);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(56, 13);
			this.typeLabel.TabIndex = 75;
			this.typeLabel.Text = "Appt Type";
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Location = new System.Drawing.Point(17, 99);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(51, 13);
			this.customerLabel.TabIndex = 74;
			this.customerLabel.Text = "Customer";
			// 
			// customerPageLabel
			// 
			this.customerPageLabel.AutoSize = true;
			this.customerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerPageLabel.Location = new System.Drawing.Point(90, 9);
			this.customerPageLabel.Name = "customerPageLabel";
			this.customerPageLabel.Size = new System.Drawing.Size(236, 31);
			this.customerPageLabel.TabIndex = 73;
			this.customerPageLabel.Text = "Edit Appointment";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 85;
			this.label1.Text = "Appt ID";
			// 
			// editApptIDComboBox
			// 
			this.editApptIDComboBox.FormattingEnabled = true;
			this.editApptIDComboBox.Location = new System.Drawing.Point(98, 48);
			this.editApptIDComboBox.Name = "editApptIDComboBox";
			this.editApptIDComboBox.Size = new System.Drawing.Size(60, 21);
			this.editApptIDComboBox.TabIndex = 86;
			// 
			// EditAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 425);
			this.Controls.Add(this.editApptIDComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.apptCancelButton);
			this.Controls.Add(this.editApptSaveButton);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.editApptEndDateTimePicker);
			this.Controls.Add(this.editApptStartDateTimePicker);
			this.Controls.Add(this.editApptComboBox);
			this.Controls.Add(this.editApptCustComboBox);
			this.Controls.Add(this.endLabel);
			this.Controls.Add(this.startLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.customerPageLabel);
			this.Name = "EditAppointment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EditAppointment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button apptCancelButton;
		private System.Windows.Forms.Button editApptSaveButton;
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.DateTimePicker editApptEndDateTimePicker;
		private System.Windows.Forms.DateTimePicker editApptStartDateTimePicker;
		private System.Windows.Forms.ComboBox editApptComboBox;
		private System.Windows.Forms.ComboBox editApptCustComboBox;
		private System.Windows.Forms.Label endLabel;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label customerLabel;
		private System.Windows.Forms.Label customerPageLabel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox editApptIDComboBox;
	}
}