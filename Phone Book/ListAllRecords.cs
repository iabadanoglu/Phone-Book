using System;
using System.Collections.Generic;

namespace Phone_Book
{
    public class ListAllRecords
    {
        public static void Init()
        {
            Console.Clear();
			string az = "A-Z";
			string za = "Z-A";

			Console.WriteLine("Lütfen kayıtları sıralı bir şekilde listelemek için seçiminizi yapınız", Console.ForegroundColor=ConsoleColor.White);
			Console.WriteLine("(1) ﻿{0}", az);
			Console.WriteLine("(2) {0}", za);

			string _input = Console.ReadLine();

			bool b = CheckValues.isPhoneNumber(_input);

			int input = 0;

			if (b) input = int.Parse(_input);

			if (input == 1) SortRecords.SortRecord(1);
			else if (input == 2) SortRecords.SortRecord(2);
			else
			{
				Console.WriteLine("Seçiminizi yapmak için lütfen 1-6 arası bir rakam girin!", Console.ForegroundColor = ConsoleColor.Red);
				Init();
			}

			Records.listAll = true;
            ListRecords.ListRecord();
            MainMenu.Menu();
        }
    }
}