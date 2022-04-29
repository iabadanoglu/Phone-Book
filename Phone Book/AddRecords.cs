using System;
using System.Collections.Generic;

namespace Phone_Book
{
	public static class AddRecords
    {
        static string name = "", surname = "", pNumber ="";
        public static void Init()
        {
            Console.Clear();

            Console.WriteLine("\nYeni Kayıt:");

            addName();
            addSurname();
            AddPhoneNumber();

            string _name = name + " " + surname;
            Records.persons.Add(pNumber, _name);
            //Records.persons.

            Console.Clear();

            Console.Write("\nKayıt işlemi başarılı            ", Console.ForegroundColor = ConsoleColor.Green);
            
            MainMenu.Menu();
        }

        static void addName()
        {
            Console.Write("\nLütfen isim giriniz             : ", Console.ForegroundColor = ConsoleColor.White);
            string str = Console.ReadLine();
            bool b = CheckValues.isName(str);

            if (b) name = str;
            else addName();
        }

        static void addSurname()
        {
            Console.Write("\nLütfen soyisim giriniz          : ", Console.ForegroundColor = ConsoleColor.White);
            string str = Console.ReadLine();
            bool b = CheckValues.isName(str);

            if (b) surname = str;
            else addSurname();
        }

        static void AddPhoneNumber()
        {
            Console.Write("\nLütfen telefon numarası giriniz : ", Console.ForegroundColor = ConsoleColor.White);
            string str = Console.ReadLine();
            bool b = CheckValues.isPhoneNumber(str);

            if (b) pNumber = str.ToString();
            else AddPhoneNumber();
        }
    }
}