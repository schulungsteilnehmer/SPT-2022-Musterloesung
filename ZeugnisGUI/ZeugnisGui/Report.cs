/*
 * Created by SharpDevelop.
 * User: neumap
 * Date: 24.03.2022
 * Time: 16:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace ZeugnisGui
{
	/// <summary>
	/// Description of Report.
	/// </summary>
	public class Report
	{	
		public string Name {
			get;
			set;
		}
		
		public string Date {
			get;
			set;
		}
		
		readonly Subject[] _subjects = {
			new Subject("Mathe"),
			new Subject("Deutsch"),
			new Subject("Englisch"),
			new Subject("Biologie"),
			new Subject("Sport"),
			new Subject("Kunst"),
			new Subject("Geschichte"),
			new Subject("Informatik")
		};
		public Subject[] Subjects {
			get { return _subjects; }
		}
		
		public int AbsentDays {
			get;
			set;
		}
		
		public int ExcusedAbsentDays {
			get;
			set;
		}
		
		public int PerformanceCourse1Index {
			get;
			private set;
		}
		
		public int PerformanceCourse2Index {
			get;
			private set;
		}
		
		
		public Report()
		{
			PerformanceCourse1Index = -1;
			PerformanceCourse2Index = -1;
		}
		
		public bool isPerfomanceCourseSettable() {
			return PerformanceCourse1Index == -1 || PerformanceCourse2Index == -1;
		}
		
		public void setPerfomanceCourse(int courseIndex) {
			if (PerformanceCourse1Index == -1) {
				PerformanceCourse1Index = courseIndex;
			} else if (PerformanceCourse2Index == -1) {
				PerformanceCourse2Index = courseIndex;
			}
		}
		
		public void unsetPerfomanceCourse(int courseIndex) {
			if (PerformanceCourse1Index == courseIndex) {
				PerformanceCourse1Index = -1;
			}
			if (PerformanceCourse2Index == courseIndex) {
				PerformanceCourse2Index = -1;
			}
		}
		
		public string toString() {
			var reportStringWriter = new StringWriter();
			reportStringWriter.WriteLine("===============Zeugnis===============");
			reportStringWriter.WriteLine("Name: {0}", Name);
			reportStringWriter.WriteLine("Datum: {0}", Date);
			reportStringWriter.WriteLine("=====================================");
			reportStringWriter.WriteLine();
			for(int i=0; i<Subjects.Length; i++){
				reportStringWriter.WriteLine("{0, -15}: {1,4}", Subjects[i].Name, Subjects[i].Points);
			}
			reportStringWriter.WriteLine();
			reportStringWriter.WriteLine("Durchschnittsnote: {0:F1}", calculateAverage());
			reportStringWriter.WriteLine("=====================================");
			reportStringWriter.WriteLine("Fehltage: {0}", AbsentDays);
			reportStringWriter.WriteLine("Davon Unentschuldigt: {0}", AbsentDays - ExcusedAbsentDays);
			reportStringWriter.WriteLine();
			if(willBeTransferred()) {
				reportStringWriter.WriteLine("Der Schüler wird versetzt.");
			}else {
				reportStringWriter.WriteLine("Der Schüler wird nicht versetzt.");
			}
			return reportStringWriter.ToString();
		}
		
		bool willBeTransferred() {
			int counter = 0;
			for (int i = 0; i < Subjects.Length; i++) {
				if (Subjects[i].Points < 5) {
					counter++;
				}
			}
			
			return (AbsentDays - ExcusedAbsentDays) < 30 && counter <= 2;
		}
		
		double calculateAverage() {
			double average = 0;
			for (int i = 0; i < Subjects.Length; i++) {
				if (i == PerformanceCourse1Index || i == PerformanceCourse2Index) {
					average += Subjects[i].Points * 2;
				} else {
					average += Subjects[i].Points;
				}
			}
			average /= (Subjects.Length + 2);
			return Math.Round((17 - average) / 3, 1);
		}
		
	}
}
