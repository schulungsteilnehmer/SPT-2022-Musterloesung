/*
 * Created by SharpDevelop.
 * User: neumap
 * Date: 23.03.2022
 * Time: 15:22
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ZeugnisGui
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox dateTextBox;
		private System.Windows.Forms.ListView subjectsListView;
		private System.Windows.Forms.GroupBox subjectDetailsBox;
		private System.Windows.Forms.CheckBox perfCourseCheckBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button generateReportBtn;
		private System.Windows.Forms.NumericUpDown pointsInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown absentDaysInput;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown excusedAbsentDaysInput;
		private System.Windows.Forms.ErrorProvider errorProviderName;
		private System.Windows.Forms.ErrorProvider errorProviderDate;
		
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTextBox = new System.Windows.Forms.TextBox();
			this.subjectsListView = new System.Windows.Forms.ListView();
			this.subjectDetailsBox = new System.Windows.Forms.GroupBox();
			this.pointsInput = new System.Windows.Forms.NumericUpDown();
			this.perfCourseCheckBox = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.generateReportBtn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.absentDaysInput = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.excusedAbsentDaysInput = new System.Windows.Forms.NumericUpDown();
			this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
			this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
			this.subjectDetailsBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pointsInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.absentDaysInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.excusedAbsentDaysInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(9, 6);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.Location = new System.Drawing.Point(54, 7);
			this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(140, 20);
			this.nameTextBox.TabIndex = 1;
			this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
			this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NameTextBoxValidating);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(211, 5);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "Datum:";
			// 
			// dateTextBox
			// 
			this.dateTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.dateTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.dateTextBox.Location = new System.Drawing.Point(265, 5);
			this.dateTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.dateTextBox.Name = "dateTextBox";
			this.dateTextBox.Size = new System.Drawing.Size(147, 20);
			this.dateTextBox.TabIndex = 3;
			this.dateTextBox.TextChanged += new System.EventHandler(this.DateTextBoxTextChanged);
			this.dateTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.DateTextBoxValidating);
			// 
			// subjectsListView
			// 
			this.subjectsListView.HideSelection = false;
			this.subjectsListView.Location = new System.Drawing.Point(9, 62);
			this.subjectsListView.Margin = new System.Windows.Forms.Padding(2);
			this.subjectsListView.MultiSelect = false;
			this.subjectsListView.Name = "subjectsListView";
			this.subjectsListView.Size = new System.Drawing.Size(144, 339);
			this.subjectsListView.TabIndex = 4;
			this.subjectsListView.UseCompatibleStateImageBehavior = false;
			this.subjectsListView.View = System.Windows.Forms.View.Details;
			this.subjectsListView.SelectedIndexChanged += new System.EventHandler(this.SubjectsListViewSelectedIndexChanged);
			// 
			// subjectDetailsBox
			// 
			this.subjectDetailsBox.Controls.Add(this.pointsInput);
			this.subjectDetailsBox.Controls.Add(this.perfCourseCheckBox);
			this.subjectDetailsBox.Controls.Add(this.label3);
			this.subjectDetailsBox.Location = new System.Drawing.Point(157, 55);
			this.subjectDetailsBox.Margin = new System.Windows.Forms.Padding(2);
			this.subjectDetailsBox.Name = "subjectDetailsBox";
			this.subjectDetailsBox.Padding = new System.Windows.Forms.Padding(2);
			this.subjectDetailsBox.Size = new System.Drawing.Size(286, 346);
			this.subjectDetailsBox.TabIndex = 5;
			this.subjectDetailsBox.TabStop = false;
			this.subjectDetailsBox.Text = "groupBox1";
			this.subjectDetailsBox.Visible = false;
			// 
			// pointsInput
			// 
			this.pointsInput.Location = new System.Drawing.Point(85, 14);
			this.pointsInput.Maximum = new decimal(new int[] {
			15,
			0,
			0,
			0});
			this.pointsInput.Name = "pointsInput";
			this.pointsInput.Size = new System.Drawing.Size(66, 20);
			this.pointsInput.TabIndex = 3;
			this.pointsInput.ValueChanged += new System.EventHandler(this.PointsInputValueChanged);
			// 
			// perfCourseCheckBox
			// 
			this.perfCourseCheckBox.Location = new System.Drawing.Point(12, 37);
			this.perfCourseCheckBox.Margin = new System.Windows.Forms.Padding(2);
			this.perfCourseCheckBox.Name = "perfCourseCheckBox";
			this.perfCourseCheckBox.Size = new System.Drawing.Size(101, 20);
			this.perfCourseCheckBox.TabIndex = 2;
			this.perfCourseCheckBox.Text = "Leistungskurs";
			this.perfCourseCheckBox.UseVisualStyleBackColor = true;
			this.perfCourseCheckBox.CheckedChanged += new System.EventHandler(this.PerfCourseCheckBoxCheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(4, 15);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "Notenpunkte:";
			// 
			// generateReportBtn
			// 
			this.generateReportBtn.Location = new System.Drawing.Point(335, 405);
			this.generateReportBtn.Margin = new System.Windows.Forms.Padding(2);
			this.generateReportBtn.Name = "generateReportBtn";
			this.generateReportBtn.Size = new System.Drawing.Size(108, 28);
			this.generateReportBtn.TabIndex = 6;
			this.generateReportBtn.Text = "Generiere Zeugnis";
			this.generateReportBtn.UseVisualStyleBackColor = true;
			this.generateReportBtn.Click += new System.EventHandler(this.GenerateReportBtnClick);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(9, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 23);
			this.label4.TabIndex = 7;
			this.label4.Text = "Fehltage:";
			// 
			// absentDaysInput
			// 
			this.absentDaysInput.Location = new System.Drawing.Point(67, 35);
			this.absentDaysInput.Maximum = new decimal(new int[] {
			190,
			0,
			0,
			0});
			this.absentDaysInput.Name = "absentDaysInput";
			this.absentDaysInput.Size = new System.Drawing.Size(120, 20);
			this.absentDaysInput.TabIndex = 8;
			this.absentDaysInput.ValueChanged += new System.EventHandler(this.AbsentDaysInputValueChanged);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(211, 33);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(105, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "Davon entschuldigt:";
			// 
			// excusedAbsentDaysInput
			// 
			this.excusedAbsentDaysInput.Location = new System.Drawing.Point(322, 33);
			this.excusedAbsentDaysInput.Name = "excusedAbsentDaysInput";
			this.excusedAbsentDaysInput.Size = new System.Drawing.Size(120, 20);
			this.excusedAbsentDaysInput.TabIndex = 10;
			this.excusedAbsentDaysInput.ValueChanged += new System.EventHandler(this.ExcusedAbsentDaysInputValueChanged);
			// 
			// errorProviderName
			// 
			this.errorProviderName.ContainerControl = this;
			// 
			// errorProviderDate
			// 
			this.errorProviderDate.ContainerControl = this;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 444);
			this.Controls.Add(this.excusedAbsentDaysInput);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.absentDaysInput);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.generateReportBtn);
			this.Controls.Add(this.subjectDetailsBox);
			this.Controls.Add(this.subjectsListView);
			this.Controls.Add(this.dateTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "ZeugnisManager";
			this.subjectDetailsBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pointsInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.absentDaysInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.excusedAbsentDaysInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
