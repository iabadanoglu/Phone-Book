using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone_Book
{
	public static class _SortRecords
	{

		static void AA()
        {
			//SortedDictionary<string, string> player = 
		}
		public static void SortRecord()
        {
			/*
			SortedDictionary<int, Player> players = new SortedDictionary<int, Player>();

			players.Add(3, new Player() { Name = "Patrice Evra", Jersey = 5 });
			players.Add(6, new Player() { Name = "Nemenja Vidic", Jersey = 26 });
			players.Add(39, new Player() { Name = "Rio Ferdinand", Jersey = 4 });
			players.Add(23, new Player() { Name = "Juan Sebestian", Jersey = 12 });
			players.Add(7, new Player() { Name = "David De Gea", Jersey = 1 });

			//foreach(KeyValuePair<int, Player> p in players)
			foreach (KeyValuePair<int, Player> p in players.OrderBy(i => i.Value.Jersey))
			{
				Console.WriteLine("{0}\t{1}\t{2}", p.Key, p.Value.Name, p.Value.Jersey);
            }
			*/
			
			SortedDictionary<string, string> players = new SortedDictionary<string, string>();

			players.Add("3", "Patrice Evra");
			players.Add("6", "Nemenja Vidic");
			players.Add("39", "Rio Ferdinand");
			players.Add("23", "Juan Sebestian");
			players.Add("7", "David De Gea");

			//Dictionary<string, string> _players = players;
			//foreach(KeyValuePair<int, Player> p in players)

			int count = 1;
			foreach (KeyValuePair<string, string> player in players.OrderBy(i => i.Value).Reverse())
			//foreach(var plaper in players)
			{
				string key = player.Key;
				string[] _name = player.Value.Split(" ");
				string name = _name[0];
				string surname = _name[1];

				Console.WriteLine("İsim: " + name);
				Console.WriteLine("Soyisim: " + surname);
				Console.WriteLine("Numara: " + key);

				if (count != players.Count) Console.WriteLine("-");

				count++;
				//Console.WriteLine("{0}\t{1}", player.Key, player.Value);
			}
			Console.ReadKey();
			/*
			Console.WriteLine("");
			foreach (KeyValuePair<string, string> player in players)
			//foreach(var plaper in players)
			{
				Console.WriteLine("{0}\t{1}", player.Key, player.Value);
			}

			Console.ReadKey();
			*/
		}
    }
}