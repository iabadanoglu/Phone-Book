using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Threading;

namespace Phone_Book
{
	public static class Records
	{
		//public static Dictionary<string, string> persons = new Dictionary<string, string>() { { "0", "Su Ak" }, { "1", "Ali Mert" }, { "2", "Suat Bingol" }, { "3", "Melis Ay" }, { "Murat", "Melis Aksu" } };
		//public static Dictionary<string, string> person = new Dictionary<string, string>();

		public static SortedDictionary<string, string> persons = new SortedDictionary<string, string>() { { "0", "Su Ak" }, { "1", "Ali Mert" }, { "2", "Suat Bingol" }, { "3", "Melis Ay" }, { "Murat", "Melis Aksu" } };
		public static SortedDictionary<string, string> person = new SortedDictionary<string, string>();


		public static string messageCompleted = "";
		public static string key = "";
		public static string val = "";
		public static string input = "";
		public static bool keyString = false;
		public static bool listAll = true;
		public static int refType = 0;
	}
}
