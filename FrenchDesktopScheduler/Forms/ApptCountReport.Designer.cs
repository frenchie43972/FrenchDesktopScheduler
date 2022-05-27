
namespace FrenchDesktopScheduler.Forms
{
	partial class ApptCountReport
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
			this.apptTotalDataGridView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.backButton = new System.Windows.Forms.Button();
			this.Appoinments = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.apptTotalDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// apptTotalDataGridView
			// 
			this.apptTotalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.apptTotalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Appoinments,
            this.Total});
			this.apptTotalDataGridView.Location = new System.Drawing.Point(50, 50);
			this.apptTotalDataGridView.Name = "apptTotalDataGridView";
			this.apptTotalDataGridView.Size = new System.Drawing.Size(240, 150);
			this.apptTotalDataGridView.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(32, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(277, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Total Number of All Appoinments ";
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(118, 240);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(100, 36);
			this.backButton.TabIndex = 7;
			this.backButton.Text = "Back to Landing";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// Appoinments
			// 
			this.Appoinments.HeaderText = "Appoinments";
			this.Appoinments.Name = "Appoinments";
			// 
			// Total
			// 
			this.Total.HeaderText = "Total";
			this.Total.Name = "Total";
			// 
			// ApptCountReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(363, 314);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.apptTotalDataGridView);
			this.Name = "ApptCountReport";
			this.Text = "ApptCount";
			((System.ComponentModel.ISupportInitialize)(this.apptTotalDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView apptTotalDataGridView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn Appoinments;
		private System.Windows.Forms.DataGridViewTextBoxColumn Total;
	}
}