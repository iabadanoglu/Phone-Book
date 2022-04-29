using System;
using System.Collections.Generic;

namespace Phone_Book
{
	public static class ListRecords
	{
        static int count = 0;
        //static Dictionary<string, string> records = new Dictionary<string, string>();
        public static void ListRecord()
		 {
            Records.person.Clear();

            Console.Clear();
            if (Records.persons.Count > 0)
            {
                string _pNum = "", _name = "", _surname = "";

                foreach (var person in Records.persons)
                {
                    string source = Records.refType == 1 ? person.Value.ToLower() : person.Key;

                    bool b = source.Contains(Records.input);

                    if (b) Records.person.Add(person.Key, person.Value);
                }
            }

            if(Records.person.Count > 0)
            {
                count = 0;

                string line1 = Records.listAll ? "Telefon Rehberi" : "Arama Sonuçlarınız:";
                string line2 = "*********************************************";

                Console.WriteLine(line1);
                Console.WriteLine(line2);

                foreach (var record in Records.person)
                {
                    string[] person = record.Value.Split(' ');

                    string pNum = record.Key;
                    string name = person[0];
                    string surname = person[1];

                    count++;

                    if(count != Records.person.Count) Print(pNum, name, surname, "-");
                    else Print(pNum, name, surname, "");
                }
            }
            else RecordNotFound();
        }

        public static void ListRecord(string num)
        {
            count = 0;

            if (Records.persons.Count > 0)
            {
                string message = num == "2" ? "Kaydı silinecek kişinin bilgileri:" : "Telefon numarası güncellenecek kişinin bilgileri:";

                Console.WriteLine(message);
                Console.WriteLine("**********************************************");

                string _pNum = "", _name = "", _surname = "";

                foreach (var person in Records.persons)
                {
                    string[] _person = person.Value.Split(' ');

                    string source = person.Value.ToLower();

                    bool b = source.Contains(Records.input);

                    if (b)
                    {
                        _pNum = person.Key;
                        _name = _person[0];
                        _surname = _person[1];

                        Records.person.Clear();
                        
                        Records.person.Add(person.Key, person.Value);
                        Records.key = person.Key;
                        Records.val= person.Value;

                        Print(_pNum, _name, _surname, "");
                        
                        count ++;
                        break;
                    }
                }

                if (count == 0) RecordNotFound();
            }
            else RecordNotFound();
        }

        public static void RecordNotFound()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı!", Console.ForegroundColor = ConsoleColor.Red);
            Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);
        }

        public static void Print(string pNum, string name, string surname, string line)
        {
            Console.WriteLine("isim: {0}", name);
            Console.WriteLine("Soyisim: {0}", surname);
            Console.WriteLine("Telefon Numarası: {0}", pNum);
            Console.WriteLine(line);
        }
    }
}