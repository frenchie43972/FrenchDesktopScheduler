
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
			// AppointmentLanding
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}