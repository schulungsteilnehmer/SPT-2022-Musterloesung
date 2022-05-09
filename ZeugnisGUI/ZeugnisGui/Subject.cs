/*
 * Created by SharpDevelop.
 * User: neumap
 * Date: 24.03.2022
 * Time: 16:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ZeugnisGui
{
	/// <summary>
	/// Description of Subject.
	/// </summary>
	public class Subject
	{
		public string Name {
			get;
			set;
		}
		
		public int Points {
			get;
			set;
		}
		
		public Subject(string name)
		{
			Name = name;
			Points = 0;
		}
		
	}
}
