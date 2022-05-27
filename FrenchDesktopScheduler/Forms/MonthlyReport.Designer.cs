
namespace FrenchDesktopScheduler.Forms
{
	partial class MonthlyReport
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
			this.monthlyDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.monthComboBox = new System.Windows.Forms.ComboBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.TypeAppt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// monthlyDataGridView
			// 
			this.monthlyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.monthlyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TypeAppt,
            this.Count});
			this.monthlyDataGridView.Location = new System.Drawing.Point(46, 71);
			this.monthlyDataGridView.Name = "monthlyDataGridView";
			this.monthlyDataGridView.Size = new System.Drawing.Size(228, 192);
			this.monthlyDataGridView.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(43, 282);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Month";
			// 
			// monthComboBox
			// 
			this.monthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.monthComboBox.FormattingEnabled = true;
			this.monthComboBox.Location = new System.Drawing.Point(104, 279);
			this.monthComboBox.Name = "monthComboBox";
			this.monthComboBox.Size = new System.Drawing.Size(121, 23);
			this.monthComboBox.TabIndex = 2;
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(104, 329);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(104, 29);
			this.submitButton.TabIndex = 3;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 370);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 29);
			this.button2.TabIndex = 4;
			this.button2.Text = "Back to Landing";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(280, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Number of Appoinments by Month";
			// 
			// TypeAppt
			// 
			this.TypeAppt.HeaderText = "Type Appt";
			this.TypeAppt.Name = "TypeAppt";
			// 
			// Count
			// 
			this.Count.HeaderText = "Count";
			this.Count.Name = "Count";
			// 
			// MonthlyReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 411);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.monthComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.monthlyDataGridView);
			this.Name = "MonthlyReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MonthlyReport";
			((System.ComponentModel.ISupportInitialize)(this.monthlyDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView monthlyDataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox monthComboBox;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn TypeAppt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
	}
}