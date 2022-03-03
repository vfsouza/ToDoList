using System;
using System.Xml;

namespace ToDoList {
	public static class Environment {
		public static void LoadEnv() {
			XmlDocument xml = new XmlDocument();
			xml.Load("../../../Environment.xml");
			System.Environment.SetEnvironmentVariable("SQL_SERVER_CON_STRING", xml.GetElementById("A1").InnerXml);
				
		}
	}
}
