using System;
using System.Collections.Generic;

namespace Phone_Book
{
    public abstract class RecordProcess
    {/*
        public static string input = "";
        static int selection = 0;
        static string message = "";
        static string selectionMessage = "";

        public static void UpdateRecord()
        {
            Console.WriteLine(Records.message1, Console.ForegroundColor = ConsoleColor.White);
            _checkNum();
            
            foreach(var person in Records.persons)
            {
                if(person.Key == Records.key)
                {
                    string _name = person.Value;
                    Console.WriteLine(person.Key+"-"+person.Value);
                    Records.persons.Remove(Records.key);
                    Records.persons.Add(input, _name);
                    Records.messageCompleted = "Görüntülenen kayıt güncellenmiştir!\n";
                }
            }
        }

        public static void FindRecord()
        {
            Console.Clear();
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine("*********************************************\n");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)\n");

            try
            {
                selection = Convert.ToInt32(Console.ReadLine());

                if (selection != 1 && selection != 2) throw new Exception();

                switch (selection)
                {
                    case 1:
                        Console.Write("\nLütfen numarasını görmek istediğiniz kişinin adını ya da soyadını giriniz: ", Console.ForegroundColor = ConsoleColor.Blue);
                        checkName();
                        break;
                    case 2:
                        Console.Write("\nLütfen numarasını görmek istediğiniz kişinin telefon numarasını giriniz: ", Console.ForegroundColor = ConsoleColor.Blue);
                        checkNum();
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Seçim için lütfen '1' ya da '2' rakamlarından birini girin!", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);

                FindRecord();
            }
        }
        public static void Selection()
        {
            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.", Console.ForegroundColor = ConsoleColor.White);
            Console.WriteLine(Records.message2);
            Console.WriteLine(" * Yeniden denemek için               : (2)\n");
            //Console.WriteLine(Records.message1);

            try
            {
                selection = Convert.ToInt32(Console.ReadLine());

                if (selection != 1 && selection != 2) throw new Exception();

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        Records.messageCompleted = "";
                        break;
                    case 2:
                        Console.WriteLine(Records.message1);
                        checkName();
                        //SearchPerson();
                        break;

                }
            }
            catch
            {
                Console.WriteLine("Seçim için lütfen '1' ya da '2' rakamlarından birini girin!", Console.ForegroundColor = ConsoleColor.Red);
                Console.WriteLine("", Console.ForegroundColor = ConsoleColor.White);

                Selection();
            }
        }

        public static void SearchPerson()
        {
            Records.messageCompleted = "";
            Console.Clear();

            bool b = false;
            
            int count = 0;
            string refInfo;
                
            foreach (var person in Records.persons)
            {
                string[] _person = person.Value.Split(' ');

                if(Records.allRecords) b = true;
                {
                    refInfo = person.Value.ToLower();
                    b = refInfo.Contains(input.ToLower());
                }
                
                if (b)
                {
                    string _pNum = person.Key;
                    string _name = _person[0];
                    string _surname = _person[1];
                    string _namePairs = _name + " " + _surname;

                    if (Records.person.Count > 0) Records.person.Clear();
                    Records.person.Add(_pNum, _namePairs);

                    Console.Write("", Console.ForegroundColor = ConsoleColor.White);
                    Console.WriteLine("İsim: {0}", _name);
                    Console.WriteLine("Soyisim: {0}", _surname);
                    Console.WriteLine("Telefon Numarası: {0}", _pNum);
                    
                    if (!Records.allRecords && count == 0)
                    {
                        if (Records.process == "delete")
                        {
                            Records.persons.Remove(_pNum);
                            Records.messageCompleted = "Yukarıdaki görüntülenen kayıt artık silinmiştir!!!\n";
                            Console.WriteLine("", Console.ForegroundColor = ConsoleColor.Red);
                        }
                        else if (Records.process == "update")
                        {

                            Records.key = person.Key;
                            UpdateRecord();
                        }
                    }

                    if (count > 0) Console.WriteLine("-");

                    count++;

                    if(!Records.allRecords) break;
                }
            }

            if (count == 0)
            {
                //Console.Clear();
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı!", Console.ForegroundColor = ConsoleColor.Red);
                Selection();
            }
        }

        public static void checkName()
        {
            string str = Console.ReadLine();
            bool b = CheckValues.isName(str);

            if (b)
            {
                input = str;
                SearchPerson();
            }
            else
            {
                if (Records.allRecords) FindRecord();
                else Selection();
            }
        }

        public static void _checkNum()
        {
            string str = Console.ReadLine();
            bool b = CheckValues.isPhoneNumber(str);

            if (b) input = str;
            else
            {

                UpdateRecord();
            }
        }
        public static void checkNum()
        {
            string str = Console.ReadLine();
            bool b = CheckValues.isPhoneNumber(str);

            if (b)
            {
                input = str;
                SearchPerson();
            }
            else
            {
                if (Records.allRecords) FindRecord();
                else Selection();
            }
        }*/
    }
}