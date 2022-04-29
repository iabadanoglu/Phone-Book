using System;
using System.Collections.Generic;

namespace Phone_Book
{
    public class FindRecords
    {
        public static void Init()
        {
            Console.Clear();
            Records.listAll = false;

            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("*********************************************\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)\n");

            try
            {
                int selection = Convert.ToInt32(Console.ReadLine());

                if (selection != 1 && selection != 2) throw new Exception();

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("\nLütfen numarasını görmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                        Records.refType = 1;
                        ListRecord();
                        break;
                    case 2:
                        Console.WriteLine("\nLütfen numarasını görmek istediğiniz kişinin telefon numarasını giriniz: ");
                        Records.refType = 2;
                        ListRecord();
                        break;
                        default: throw new Exception();
                }
            }
            catch
            {
                Console.WriteLine("Seçim için lütfen '1' ya da '2' rakamlarından birini girin!", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);

                Init();
            }
        }
        
        static void ListRecord()
        {
            Records.input = Console.ReadLine().ToLower();
            ListRecords.ListRecord();
            MainMenu.Menu();
        }
    }
}