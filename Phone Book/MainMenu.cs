using System;
using System.Collections.Generic;
using System.Linq;

namespace Phone_Book
{
    public static class MainMenu
    {
        public static void Menu()
        {
			//Console.Clear();
			Console.WriteLine();
			Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);
			Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
			Console.WriteLine("*******************************************");
			Console.WriteLine("(1) Yeni Numara Kaydetmek");
			Console.WriteLine("(2) Varolan Numarayı Silmek");
			Console.WriteLine("(3) Varolan Numarayı Güncelleme");
			Console.WriteLine("(4) Rehberi Listelemek");
			Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
			Console.WriteLine("(6) Çıkış﻿\n");

			string _input = Console.ReadLine();

			bool b = CheckValues.isPhoneNumber(_input);

			int input = 0;

			if (b) input = int.Parse(_input);

			if (input == (int)Processes.Add) AddRecords.Init();
			else if (input == (int)Processes.Delete) DeleteRecords.Init();
			else if (input == (int)Processes.Update) UpdateRecords.Init();
			else if (input == (int)Processes.List) ListAllRecords.Init();
			else if (input == (int)Processes.Find) FindRecords.Init();
			else if (input == (int)Processes.Exit) Environment.Exit(0);
			else
			{
				Console.WriteLine("Seçiminizi yapmak için lütfen 1-6 arası bir rakam girin!", Console.ForegroundColor = ConsoleColor.Red);
				Menu();
			}
		}
    }
}

public enum Processes
{
	Add = 1,
	Delete = 2,
	Update = 3,
	List = 4,
	Find = 5,
	Exit
}

public class Player
{
	public string Name { get; set; }
	public int Jersey { get; set; }
}

//Unity Essentials ve Unity Junior Programmer kurslarını daha önce https://learn.unity.com/ sitesinden almıştım. (https://learn.unity.com/u/5c477872edbc2a10c4418b02?tab=profile) patika.dev ile entegrasyonu mümkün olabilir mi acaba? 