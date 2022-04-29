using System;
using System.Collections.Generic;

namespace Phone_Book
{
    public class UpdateRecords
    {
        public static void Init()
        {
            Console.Clear();

            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");

            string input = Console.ReadLine();
            Records.input = input;

            ListRecords.ListRecord("3");

            if (Records.person.Count > 0)
            {
                foreach (var person in Records.persons)
                {
                    if (person.Value.ToLower().Contains(Records.val.ToLower()))
                    {
                        Console.WriteLine("Lütfen yeni numarayı giriniz.");
                        string num = Console.ReadLine();

                        bool b = CheckValues.isPhoneNumber(num);

                        if(b)
                        {
                            Console.WriteLine("val: " + person.Key + "-" + Records.key + "-" + person.Value + "-" + Records.val);
                            Records.persons.Remove(Records.key);
                            Records.persons.Add(num, Records.val);
                            
                            Console.Clear();
                            
                            Console.WriteLine("Güncelleme işlemi başarılı");
                        }

                        
                        break;
                    }
                }
                MainMenu.Menu();
            }
            else
            {
                TryAgain();
            }
        }

        static void TryAgain()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
            Console.WriteLine("* Yeniden denemek için           : (2)");

            string _input = Console.ReadLine();

            if (_input == "1" || _input == "2")
            {
                if (_input == "1") MainMenu.Menu();
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