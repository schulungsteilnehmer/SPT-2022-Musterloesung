/*
 * Created by SharpDevelop.
 * User: neumap
 * Date: 25.03.2022
 * Time: 10:29
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ZeugnisGui
{
	/// <summary>
	/// Description of ReportResultDialog.
	/// </summary>
	public partial class ReportResultDialog : Form
	{
		
		String reportString;
		
		public ReportResultDialog(String reportString)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			this.reportString = reportString;
			reportStringView.Text = reportString;
			
			if (reportString.Contains("Der Schüler wird versetzt.")) {
				reportStringView.Find("Der Schüler wird versetzt.", RichTextBoxFinds.MatchCase);
				reportStringView.SelectionColor = Color.Green;
			} else if (reportString.Contains("Der Schüler wird nicht versetzt.")) {
				reportStringView.Find("Der Schüler wird nicht versetzt.", RichTextBoxFinds.MatchCase);
				reportStringView.SelectionColor = Color.Red;
			}
		}
		
		void CloseButtonClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void SaveToFileButtonClick(object sender, EventArgs e)
		{
			var writer = new StreamWriter("Zeugnis.txt");
			writer.WriteLine(reportString);
			writer.Close();
			saveToFileButton.Text = "Gespeichert";
			saveToFileButton.Enabled = false;
		}
	}
}
