﻿
namespace FrenchDesktopScheduler.Forms
{
	partial class AddAppointment
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
			this.endLabel = new System.Windows.Forms.Label();
			this.startLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.customerLabel = new System.Windows.Forms.Label();
			this.addApptEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.addApptStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.addApptComboBox = new System.Windows.Forms.ComboBox();
			this.addApptCustComboBox = new System.Windows.Forms.ComboBox();
			this.toLandingButton = new System.Windows.Forms.Button();
			this.addApptSaveButton = new System.Windows.Forms.Button();
			this.apptCancelButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// customerPageLabel
			// 
			this.customerPageLabel.AutoSize = true;
			this.customerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerPageLabel.Location = new System.Drawing.Point(30, 9);
			this.customerPageLabel.Name = "customerPageLabel";
			this.customerPageLabel.Size = new System.Drawing.Size(332, 31);
			this.customerPageLabel.TabIndex = 59;
			this.customerPageLabel.Text = "Appointment Information";
			// 
			// endLabel
			// 
			this.endLabel.AutoSize = true;
			this.endLabel.Location = new System.Drawing.Point(17, 230);
			this.endLabel.Name = "endLabel";
			this.endLabel.Size = new System.Drawing.Size(26, 13);
			this.endLabel.TabIndex = 64;
			this.endLabel.Text = "End";
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(17, 180);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(29, 13);
			this.startLabel.TabIndex = 63;
			this.startLabel.Text = "Start";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(17, 125);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(56, 13);
			this.typeLabel.TabIndex = 62;
			this.typeLabel.Text = "Appt Type";
			// 
			// customerLabel
			// 
			this.customerLabel.AutoSize = true;
			this.customerLabel.Location = new System.Drawing.Point(17, 74);
			this.customerLabel.Name = "customerLabel";
			this.customerLabel.Size = new System.Drawing.Size(51, 13);
			this.customerLabel.TabIndex = 61;
			this.customerLabel.Text = "Customer";
			// 
			// addApptEndDateTimePicker
			// 
			this.addApptEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.addApptEndDateTimePicker.Location = new System.Drawing.Point(97, 224);
			this.addApptEndDateTimePicker.Name = "addApptEndDateTimePicker";
			this.addApptEndDateTimePicker.Size = new System.Drawing.Size(265, 20);
			this.addApptEndDateTimePicker.TabIndex = 69;
			// 
			// addApptStartDateTimePicker
			// 
			this.addApptStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.addApptStartDateTimePicker.Location = new System.Drawing.Point(97, 174);
			this.addApptStartDateTimePicker.Name = "addApptStartDateTimePicker";
			this.addApptStartDateTimePicker.Size = new System.Drawing.Size(265, 20);
			this.addApptStartDateTimePicker.TabIndex = 68;
			// 
			// addApptComboBox
			// 
			this.addApptComboBox.FormattingEnabled = true;
			this.addApptComboBox.Location = new System.Drawing.Point(98, 118);
			this.addApptComboBox.Name = "addApptComboBox";
			this.addApptComboBox.Size = new System.Drawing.Size(266, 21);
			this.addApptComboBox.TabIndex = 67;
			// 
			// addApptCustComboBox
			// 
			this.addApptCustComboBox.FormattingEnabled = true;
			this.addApptCustComboBox.Location = new System.Drawing.Point(97, 67);
			this.addApptCustComboBox.Name = "addApptCustComboBox";
			this.addApptCustComboBox.Size = new System.Drawing.Size(265, 21);
			this.addApptCustComboBox.TabIndex = 66;
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(217, 272);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 70;
			this.toLandingButton.Text = "To Appointment Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// addApptSaveButton
			// 
			this.addApptSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addApptSaveButton.Location = new System.Drawing.Point(14, 272);
			this.addApptSaveButton.Name = "addApptSaveButton";
			this.addApptSaveButton.Size = new System.Drawing.Size(145, 47);
			this.addApptSaveButton.TabIndex = 71;
			this.addApptSaveButton.Text = "Save";
			this.addApptSaveButton.UseVisualStyleBackColor = true;
			this.addApptSaveButton.Click += new System.EventHandler(this.addApptSaveButton_Click);
			// 
			// apptCancelButton
			// 
			this.apptCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.apptCancelButton.Location = new System.Drawing.Point(113, 341);
			this.apptCancelButton.Name = "apptCancelButton";
			this.apptCancelButton.Size = new System.Drawing.Size(145, 47);
			this.apptCancelButton.TabIndex = 72;
			this.apptCancelButton.Text = "Cancel";
			this.apptCancelButton.UseVisualStyleBackColor = true;
			this.apptCancelButton.Click += new System.EventHandler(this.apptCancelButton_Click);
			// 
			// AddAppointment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(386, 425);
			this.Controls.Add(this.apptCancelButton);
			this.Controls.Add(this.addApptSaveButton);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.addApptEndDateTimePicker);
			this.Controls.Add(this.addApptStartDateTimePicker);
			this.Controls.Add(this.addApptComboBox);
			this.Controls.Add(this.addApptCustComboBox);
			this.Controls.Add(this.endLabel);
			this.Controls.Add(this.startLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.customerLabel);
			this.Controls.Add(this.customerPageLabel);
			this.Name = "AddAppointment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddAppointment";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label customerPageLabel;
		private System.Windows.Forms.Label endLabel;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.Label customerLabel;
		private System.Windows.Forms.DateTimePicker addApptEndDateTimePicker;
		private System.Windows.Forms.DateTimePicker addApptStartDateTimePicker;
		private System.Windows.Forms.ComboBox addApptComboBox;
		private System.Windows.Forms.ComboBox addApptCustComboBox;
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.Button addApptSaveButton;
		private System.Windows.Forms.Button apptCancelButton;
	}
}