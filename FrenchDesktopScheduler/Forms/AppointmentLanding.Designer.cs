﻿
namespace FrenchDesktopScheduler.Forms
{
	partial class AppointmentLanding
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
			this.customerPageLabel = new System.Windows.Forms.Label();
			this.toLandingButton = new System.Windows.Forms.Button();
			this.btnAddAppt = new System.Windows.Forms.Button();
			this.btnEditAppt = new System.Windows.Forms.Button();
			this.editApptEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.editApptStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.endLabel = new System.Windows.Forms.Label();
			this.startLabel = new System.Windows.Forms.Label();
			this.typeLabel = new System.Windows.Forms.Label();
			this.ApptTypeTextBox = new System.Windows.Forms.TextBox();
			this.btnDeleteAppt = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSaveEdit = new System.Windows.Forms.Button();
			this.apptIDTextBox = new System.Windows.Forms.TextBox();
			this.labelApptID = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.filterWeekRadio = new System.Windows.Forms.RadioButton();
			this.filterMonthRadio = new System.Windows.Forms.RadioButton();
			this.editUserIDTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.searchAppt = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.searchBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(555, 59);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			// 
			// appointmentDataGridView
			// 
			this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.appointmentDataGridView.Location = new System.Drawing.Point(12, 49);
			this.appointmentDataGridView.MultiSelect = false;
			this.appointmentDataGridView.Name = "appointmentDataGridView";
			this.appointmentDataGridView.ReadOnly = true;
			this.appointmentDataGridView.Size = new System.Drawing.Size(524, 184);
			this.appointmentDataGridView.TabIndex = 59;
			// 
			// customerPageLabel
			// 
			this.customerPageLabel.AutoSize = true;
			this.customerPageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.customerPageLabel.Location = new System.Drawing.Point(241, 6);
			this.customerPageLabel.Name = "customerPageLabel";
			this.customerPageLabel.Size = new System.Drawing.Size(332, 31);
			this.customerPageLabel.TabIndex = 58;
			this.customerPageLabel.Text = "Appointment Information";
			// 
			// toLandingButton
			// 
			this.toLandingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.toLandingButton.Location = new System.Drawing.Point(637, 391);
			this.toLandingButton.Name = "toLandingButton";
			this.toLandingButton.Size = new System.Drawing.Size(145, 47);
			this.toLandingButton.TabIndex = 60;
			this.toLandingButton.Text = "Back to Landing Page";
			this.toLandingButton.UseVisualStyleBackColor = true;
			this.toLandingButton.Click += new System.EventHandler(this.toLandingButton_Click);
			// 
			// btnAddAppt
			// 
			this.btnAddAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddAppt.Location = new System.Drawing.Point(12, 391);
			this.btnAddAppt.Name = "btnAddAppt";
			this.btnAddAppt.Size = new System.Drawing.Size(145, 47);
			this.btnAddAppt.TabIndex = 61;
			this.btnAddAppt.Text = "Add Appointment";
			this.btnAddAppt.UseVisualStyleBackColor = true;
			this.btnAddAppt.Click += new System.EventHandler(this.btnAddAppt_Click);
			// 
			// btnEditAppt
			// 
			this.btnEditAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEditAppt.Location = new System.Drawing.Point(174, 391);
			this.btnEditAppt.Name = "btnEditAppt";
			this.btnEditAppt.Size = new System.Drawing.Size(145, 47);
			this.btnEditAppt.TabIndex = 62;
			this.btnEditAppt.Text = "Edit Appointment";
			this.btnEditAppt.UseVisualStyleBackColor = true;
			this.btnEditAppt.Click += new System.EventHandler(this.btnEditAppt_Click);
			// 
			// editApptEndDateTimePicker
			// 
			this.editApptEndDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.editApptEndDateTimePicker.Location = new System.Drawing.Point(92, 350);
			this.editApptEndDateTimePicker.Name = "editApptEndDateTimePicker";
			this.editApptEndDateTimePicker.Size = new System.Drawing.Size(265, 20);
			this.editApptEndDateTimePicker.TabIndex = 86;
			// 
			// editApptStartDateTimePicker
			// 
			this.editApptStartDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.editApptStartDateTimePicker.Location = new System.Drawing.Point(92, 300);
			this.editApptStartDateTimePicker.Name = "editApptStartDateTimePicker";
			this.editApptStartDateTimePicker.Size = new System.Drawing.Size(265, 20);
			this.editApptStartDateTimePicker.TabIndex = 85;
			// 
			// endLabel
			// 
			this.endLabel.AutoSize = true;
			this.endLabel.Location = new System.Drawing.Point(12, 356);
			this.endLabel.Name = "endLabel";
			this.endLabel.Size = new System.Drawing.Size(26, 13);
			this.endLabel.TabIndex = 84;
			this.endLabel.Text = "End";
			// 
			// startLabel
			// 
			this.startLabel.AutoSize = true;
			this.startLabel.Location = new System.Drawing.Point(12, 306);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(29, 13);
			this.startLabel.TabIndex = 83;
			this.startLabel.Text = "Start";
			// 
			// typeLabel
			// 
			this.typeLabel.AutoSize = true;
			this.typeLabel.Location = new System.Drawing.Point(12, 251);
			this.typeLabel.Name = "typeLabel";
			this.typeLabel.Size = new System.Drawing.Size(56, 13);
			this.typeLabel.TabIndex = 82;
			this.typeLabel.Text = "Appt Type";
			// 
			// ApptTypeTextBox
			// 
			this.ApptTypeTextBox.Location = new System.Drawing.Point(92, 248);
			this.ApptTypeTextBox.Name = "ApptTypeTextBox";
			this.ApptTypeTextBox.Size = new System.Drawing.Size(176, 20);
			this.ApptTypeTextBox.TabIndex = 87;
			// 
			// btnDeleteAppt
			// 
			this.btnDeleteAppt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDeleteAppt.Location = new System.Drawing.Point(337, 391);
			this.btnDeleteAppt.Name = "btnDeleteAppt";
			this.btnDeleteAppt.Size = new System.Drawing.Size(145, 47);
			this.btnDeleteAppt.TabIndex = 88;
			this.btnDeleteAppt.Text = "Delete Appointment";
			this.btnDeleteAppt.UseVisualStyleBackColor = true;
			this.btnDeleteAppt.Click += new System.EventHandler(this.btnDeleteAppt_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(637, 323);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(145, 47);
			this.btnCancel.TabIndex = 89;
			this.btnCancel.Text = "Cancel / Clear";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSaveEdit
			// 
			this.btnSaveEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSaveEdit.Location = new System.Drawing.Point(637, 251);
			this.btnSaveEdit.Name = "btnSaveEdit";
			this.btnSaveEdit.Size = new System.Drawing.Size(145, 47);
			this.btnSaveEdit.TabIndex = 90;
			this.btnSaveEdit.Text = "Save Edit";
			this.btnSaveEdit.UseVisualStyleBackColor = true;
			this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
			// 
			// apptIDTextBox
			// 
			this.apptIDTextBox.Location = new System.Drawing.Point(337, 248);
			this.apptIDTextBox.Name = "apptIDTextBox";
			this.apptIDTextBox.Size = new System.Drawing.Size(42, 20);
			this.apptIDTextBox.TabIndex = 92;
			// 
			// labelApptID
			// 
			this.labelApptID.AutoSize = true;
			this.labelApptID.Location = new System.Drawing.Point(276, 251);
			this.labelApptID.Name = "labelApptID";
			this.labelApptID.Size = new System.Drawing.Size(43, 13);
			this.labelApptID.TabIndex = 91;
			this.labelApptID.Text = "Appt ID";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(419, 267);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 16);
			this.label1.TabIndex = 93;
			this.label1.Text = "Filter Appointments By:";
			// 
			// filterWeekRadio
			// 
			this.filterWeekRadio.AutoSize = true;
			this.filterWeekRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterWeekRadio.Location = new System.Drawing.Point(424, 300);
			this.filterWeekRadio.Name = "filterWeekRadio";
			this.filterWeekRadio.Size = new System.Drawing.Size(58, 17);
			this.filterWeekRadio.TabIndex = 96;
			this.filterWeekRadio.TabStop = true;
			this.filterWeekRadio.Text = "Week";
			this.filterWeekRadio.UseVisualStyleBackColor = true;
			this.filterWeekRadio.CheckedChanged += new System.EventHandler(this.filterWeekRadio_CheckedChanged);
			// 
			// filterMonthRadio
			// 
			this.filterMonthRadio.AutoSize = true;
			this.filterMonthRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.filterMonthRadio.Location = new System.Drawing.Point(515, 300);
			this.filterMonthRadio.Name = "filterMonthRadio";
			this.filterMonthRadio.Size = new System.Drawing.Size(60, 17);
			this.filterMonthRadio.TabIndex = 97;
			this.filterMonthRadio.TabStop = true;
			this.filterMonthRadio.Text = "Month";
			this.filterMonthRadio.UseVisualStyleBackColor = true;
			this.filterMonthRadio.CheckedChanged += new System.EventHandler(this.filterMonthRadio_CheckedChanged);
			// 
			// editUserIDTextBox
			// 
			this.editUserIDTextBox.Location = new System.Drawing.Point(424, 349);
			this.editUserIDTextBox.Name = "editUserIDTextBox";
			this.editUserIDTextBox.Size = new System.Drawing.Size(42, 20);
			this.editUserIDTextBox.TabIndex = 99;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(363, 352);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 13);
			this.label2.TabIndex = 98;
			this.label2.Text = "User ID";
			// 
			// searchAppt
			// 
			this.searchAppt.Location = new System.Drawing.Point(511, 365);
			this.searchAppt.Name = "searchAppt";
			this.searchAppt.Size = new System.Drawing.Size(100, 20);
			this.searchAppt.TabIndex = 100;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(512, 349);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 101;
			this.label3.Text = "Customer Search";
			// 
			// searchBtn
			// 
			this.searchBtn.Location = new System.Drawing.Point(525, 391);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(75, 23);
			this.searchBtn.TabIndex = 102;
			this.searchBtn.Text = "Search";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// AppointmentLanding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.searchAppt);
			this.Controls.Add(this.editUserIDTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.filterMonthRadio);
			this.Controls.Add(this.filterWeekRadio);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.apptIDTextBox);
			this.Controls.Add(this.labelApptID);
			this.Controls.Add(this.btnSaveEdit);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnDeleteAppt);
			this.Controls.Add(this.ApptTypeTextBox);
			this.Controls.Add(this.editApptEndDateTimePicker);
			this.Controls.Add(this.editApptStartDateTimePicker);
			this.Controls.Add(this.endLabel);
			this.Controls.Add(this.startLabel);
			this.Controls.Add(this.typeLabel);
			this.Controls.Add(this.btnEditAppt);
			this.Controls.Add(this.btnAddAppt);
			this.Controls.Add(this.toLandingButton);
			this.Controls.Add(this.appointmentDataGridView);
			this.Controls.Add(this.customerPageLabel);
			this.Controls.Add(this.monthCalendar1);
			this.Name = "AppointmentLanding";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Appointment";
			((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.DataGridView appointmentDataGridView;
		private System.Windows.Forms.Label customerPageLabel;
		private System.Windows.Forms.Button toLandingButton;
		private System.Windows.Forms.Button btnAddAppt;
		private System.Windows.Forms.Button btnEditAppt;
		private System.Windows.Forms.DateTimePicker editApptEndDateTimePicker;
		private System.Windows.Forms.DateTimePicker editApptStartDateTimePicker;
		private System.Windows.Forms.Label endLabel;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label typeLabel;
		private System.Windows.Forms.TextBox ApptTypeTextBox;
		private System.Windows.Forms.Button btnDeleteAppt;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSaveEdit;
		private System.Windows.Forms.TextBox apptIDTextBox;
		private System.Windows.Forms.Label labelApptID;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton filterWeekRadio;
		private System.Windows.Forms.RadioButton filterMonthRadio;
		private System.Windows.Forms.TextBox editUserIDTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox searchAppt;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button searchBtn;
	}
}