
namespace FrenchDesktopScheduler.Forms
{
	partial class ConsultantReport
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
			this.backButton = new System.Windows.Forms.Button();
			this.submitButton = new System.Windows.Forms.Button();
			this.userComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.userDataGridView = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.Location = new System.Drawing.Point(159, 369);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(104, 29);
			this.backButton.TabIndex = 8;
			this.backButton.Text = "Back to Landing";
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.backButton_Click);
			// 
			// submitButton
			// 
			this.submitButton.Location = new System.Drawing.Point(159, 328);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(104, 29);
			this.submitButton.TabIndex = 7;
			this.submitButton.Text = "Submit";
			this.submitButton.UseVisualStyleBackColor = true;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// userComboBox
			// 
			this.userComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userComboBox.FormattingEnabled = true;
			this.userComboBox.Location = new System.Drawing.Point(159, 278);
			this.userComboBox.Name = "userComboBox";
			this.userComboBox.Size = new System.Drawing.Size(121, 23);
			this.userComboBox.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(98, 281);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "User";
			// 
			// userDataGridView
			// 
			this.userDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.userDataGridView.Location = new System.Drawing.Point(12, 69);
			this.userDataGridView.Name = "userDataGridView";
			this.userDataGridView.Size = new System.Drawing.Size(381, 187);
			this.userDataGridView.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(86, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(229, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "Appoinments by Consultant";
			// 
			// ConsultantReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(405, 411);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.userDataGridView);
			this.Controls.Add(this.backButton);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.userComboBox);
			this.Controls.Add(this.label1);
			this.Name = "ConsultantReport";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ConsultantReport";
			((System.ComponentModel.ISupportInitialize)(this.userDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backButton;
		private System.Windows.Forms.Button submitButton;
		private System.Windows.Forms.ComboBox userComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView userDataGridView;
		private System.Windows.Forms.Label label2;
	}
}