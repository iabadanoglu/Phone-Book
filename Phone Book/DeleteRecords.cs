using System;
using System.Collections.Generic;

namespace Phone_Book
{
    static class DeleteRecords
    {
        public static void Init()
        {
            Console.Clear();

            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            
            string input = Console.ReadLine();
            Records.input = input;

            ListRecords.ListRecord("2");

            if(Records.person.Count > 0)
            {
                foreach(var person in Records.persons)
                {
                    if (person.Value.ToLower().Contains(Records.val.ToLower()))
                    {
                        Console.Clear();
                        Records.persons.Remove(Records.key);
                        Console.WriteLine("Silme işlemi başarılı\n");
                        break;
                    }
                }
                MainMenu.Menu();
            }
            else
            {
                Console.Clear();
                TryAgain();
            }
        }

        static void TryAgain()
        {
            Console.Clear();
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için      : (2)");

            string _input = Console.ReadLine();

            if (_input == "1" || _input == "2")
            {
                if (_input == "1")
                {
                    Console.Clear ();
                    MainMenu.Menu();
                }
                else Init();
            }
            else
            {
                Console.WriteLine("Seçim için lütfen '1! ya da '2' rakamlarından birini giriniz!", Console.ForegroundColor = ConsoleColor.Red);
                TryAgain();
            }
        }
    }
}