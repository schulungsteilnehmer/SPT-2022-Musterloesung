/*
 * Created by SharpDevelop.
 * User: neumap
 * Date: 23.03.2022
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ZeugnisGui
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		Report report = new Report();
		int selectedIndex = -1;
		Subject selectedSubject;
		bool updatingDetails = false;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			subjectsListView.Columns.Add("Fach", 90);
			subjectsListView.Columns.Add("Punkte", 50);
			this.ActiveControl = subjectsListView;
			
			var autoCompleteStrings = new AutoCompleteStringCollection();
			autoCompleteStrings.Add(DateTime.Now.Date.ToString("dd.MM.yyyy") + " (Heute)");
			dateTextBox.AutoCompleteCustomSource = autoCompleteStrings;
			
			updateSubjectsListView();
		}
		
		void updateSubjectsListView() {
			subjectsListView.Items.Clear();
			for (int i = 0; i < report.Subjects.Length; i++) {
				ListViewItem item;
				if (i == report.PerformanceCourse1Index || i == report.PerformanceCourse2Index) {
					item = new ListViewItem(new []{report.Subjects[i].Name + "(LK)", Convert.ToString(report.Subjects[i].Points)});
				} else {
					item = new ListViewItem(new []{report.Subjects[i].Name, Convert.ToString(report.Subjects[i].Points)});
				}
				subjectsListView.Items.Add(item);
			}
			if (selectedIndex != -1) {
				subjectsListView.SelectedIndices.Clear();
				subjectsListView.SelectedIndices.Add(selectedIndex);
			}
		}
		
		void SubjectsListViewSelectedIndexChanged(object sender, EventArgs e)
		{
			if (subjectsListView.SelectedIndices.Count == 1) {
				updatingDetails = true;
				selectedIndex = subjectsListView.SelectedIndices[0];
				selectedSubject = report.Subjects[selectedIndex];
				subjectDetailsBox.Text = selectedSubject.Name;
				pointsInput.Value = selectedSubject.Points;
				bool isPerformanceCourse = (selectedIndex == report.PerformanceCourse1Index || selectedIndex == report.PerformanceCourse2Index);
				if (!isPerformanceCourse && !report.isPerfomanceCourseSettable()) {
					perfCourseCheckBox.Enabled = false;
				} else {
					perfCourseCheckBox.Enabled = true;
				}
				perfCourseCheckBox.Checked = isPerformanceCourse;
				updatingDetails = false;
				subjectDetailsBox.Visible = true;
			} else {
				subjectDetailsBox.Visible = false;
				selectedIndex = -1;
			}
		}
		
		void NameTextBoxTextChanged(object sender, EventArgs e)
		{
			report.Name = nameTextBox.Text;
		}
		
		void NameTextBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			string error = null;
			if (nameTextBox.Text.Length == 0) {
				error = "Bitte einen Namen eingeben!";
				e.Cancel = true;
			}
			errorProviderName.SetError((Control) sender, error);
		}
		
		void DateTextBoxTextChanged(object sender, EventArgs e)
		{
			report.Date = dateTextBox.Text.Replace(" (Heute)", "");
		}
		
		void DateTextBoxValidating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			var regexDate = new Regex(@"^(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})$");
			string error = null;
			if (dateTextBox.Text.Length == 0) {
				dateTextBox.Text = dateTextBox.AutoCompleteCustomSource[0];
			}
			if (!regexDate.IsMatch(dateTextBox.Text.Replace(" (Heute)", ""))) {
				error = "Sie müssen ein korrektes Datumsformat tt.mm.jjjj angeben!";
				e.Cancel = true;
			}
			errorProviderDate.SetError((Control) sender, error);
		}
		
		void AbsentDaysInputValueChanged(object sender, EventArgs e)
		{
			report.AbsentDays = Convert.ToInt32(absentDaysInput.Value);
			excusedAbsentDaysInput.Maximum = absentDaysInput.Value;
		}
		
		void ExcusedAbsentDaysInputValueChanged(object sender, EventArgs e)
		{
			report.ExcusedAbsentDays = Convert.ToInt32(excusedAbsentDaysInput.Value);
		}
		
		void PointsInputValueChanged(object sender, EventArgs e)
		{
			if (updatingDetails) return;
			selectedSubject.Points = Convert.ToInt32(pointsInput.Value);
			updateSubjectsListView();
		}
		
		void PerfCourseCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (updatingDetails) return;
			if (perfCourseCheckBox.Checked) {
				report.setPerfomanceCourse(selectedIndex);
			} else {
				report.unsetPerfomanceCourse(selectedIndex);
			}
			updateSubjectsListView();
		}
		
		void GenerateReportBtnClick(object sender, EventArgs e)
		{
			if (!ValidateChildren()) {
				return;
			}
			if (report.isPerfomanceCourseSettable()) {
				MessageBox.Show(this, "Du musst 2 Fächer als Leistungskurs festlegen!", "Fehler", MessageBoxButtons.OK);
				return;
			}
			string reportString = report.toString();
			new ReportResultDialog(reportString).ShowDialog(this);
		}
	}
}
