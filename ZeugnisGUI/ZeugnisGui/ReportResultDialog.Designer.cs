/*
 * Created by SharpDevelop.
 * User: neumap
 * Date: 25.03.2022
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZeugnisGui
{
	partial class ReportResultDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button saveToFileButton;
		private System.Windows.Forms.RichTextBox reportStringView;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.closeButton = new System.Windows.Forms.Button();
			this.saveToFileButton = new System.Windows.Forms.Button();
			this.reportStringView = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(407, 416);
			this.closeButton.Margin = new System.Windows.Forms.Padding(4);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(100, 28);
			this.closeButton.TabIndex = 1;
			this.closeButton.Text = "Schließen";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.CloseButtonClick);
			// 
			// saveToFileButton
			// 
			this.saveToFileButton.Location = new System.Drawing.Point(225, 415);
			this.saveToFileButton.Margin = new System.Windows.Forms.Padding(4);
			this.saveToFileButton.Name = "saveToFileButton";
			this.saveToFileButton.Size = new System.Drawing.Size(173, 28);
			this.saveToFileButton.TabIndex = 2;
			this.saveToFileButton.Text = "Speichern in Zeugnis.txt";
			this.saveToFileButton.UseVisualStyleBackColor = true;
			this.saveToFileButton.Click += new System.EventHandler(this.SaveToFileButtonClick);
			// 
			// reportStringView
			// 
			this.reportStringView.Location = new System.Drawing.Point(12, 12);
			this.reportStringView.Name = "reportStringView";
			this.reportStringView.Size = new System.Drawing.Size(499, 396);
			this.reportStringView.TabIndex = 3;
			this.reportStringView.Text = "";
			// 
			// ReportResultDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(523, 459);
			this.Controls.Add(this.reportStringView);
			this.Controls.Add(this.saveToFileButton);
			this.Controls.Add(this.closeButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "ReportResultDialog";
			this.Text = "Zeugnis";
			this.ResumeLayout(false);

		}
	}
}
