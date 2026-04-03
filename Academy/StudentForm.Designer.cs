namespace Academy
{
	partial class StudentForm
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
			this.cbGroup = new System.Windows.Forms.ComboBox();
			this.LabelGroup = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbGroup
			// 
			this.cbGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbGroup.FormattingEnabled = true;
			this.cbGroup.Location = new System.Drawing.Point(251, 335);
			this.cbGroup.Name = "cbGroup";
			this.cbGroup.Size = new System.Drawing.Size(325, 33);
			this.cbGroup.TabIndex = 14;
			// 
			// LabelGroup
			// 
			this.LabelGroup.AutoSize = true;
			this.LabelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LabelGroup.Location = new System.Drawing.Point(120, 339);
			this.LabelGroup.Name = "LabelGroup";
			this.LabelGroup.Size = new System.Drawing.Size(89, 25);
			this.LabelGroup.TabIndex = 15;
			this.LabelGroup.Text = "Группа:";
			// 
			// StudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(827, 519);
			this.Controls.Add(this.LabelGroup);
			this.Controls.Add(this.cbGroup);
			this.Name = "StudentForm";
			this.Text = "StudentForm";
			this.Controls.SetChildIndex(this.cbGroup, 0);
			this.Controls.SetChildIndex(this.LabelGroup, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbGroup;
		private System.Windows.Forms.Label LabelGroup;
	}
}