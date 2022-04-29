using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone_Book
{
	public static class SortRecords
	{
		public static void SortRecord(int num)
        {
			Console.Clear();

			int count = 1;

			if (num == 1)
			{
				foreach (KeyValuePair<string, string> person in Records.persons.OrderBy(i => i.Value))
				{
					string key = person.Key;
					string[] _name = person.Value.Split(" ");
					string name = _name[0];
					string surname = _name[1];

					Console.WriteLine("İsim: " + name);
					Console.WriteLine("Soyisim: " + surname);
					Console.WriteLine("Numara: " + key);

					if (count != Records.persons.Count) Console.WriteLine("-");

					count++;
					//Console.WriteLine("{0}\t{1}", player.Key, player.Value);
				}
			}
			else
            {
				foreach (KeyValuePair<string, string> person in Records.persons.OrderBy(i => i.Value).Reverse())
				{
					string key = person.Key;
					string[] _name = person.Value.Split(" ");
					string name = _name[0];
					string surname = _name[1];

					Console.WriteLine("İsim: " + name);
					Console.WriteLine("Soyisim: " + surname);
					Console.WriteLine("Numara: " + key);

					if (count != Records.persons.Count) Console.WriteLine("-");

					count++;
					//Console.WriteLine("{0}\t{1}", player.Key, player.Value);
				}
			}

			MainMenu.Menu();
		}
    }
}