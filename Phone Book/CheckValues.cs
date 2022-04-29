using System;

namespace Phone_Book
{
	public class CheckValues
	{
        public static bool isPhoneNumber(string phoneNumber)
        {
            int _phoneNumber;
            bool b;

            try
            {
                b = int.TryParse(phoneNumber, out _phoneNumber);

                if (!b)
                {
                    Console.WriteLine("Telefon numarası alfa numerik karakter (rakam) içermemeli!\n", Console.ForegroundColor = ConsoleColor.Red);
                    return false;
                }

                if (phoneNumber.Length != 10)
                {
                    //throw new Exception();
                }

                return true;
            }
            catch
            {
                if (phoneNumber.Length != 10) Console.WriteLine("Telefon numarası 10 haneden oluşmalıdır!\n", Console.ForegroundColor = ConsoleColor.Red);

                return false;
            }
        }

        public static bool isName(string name)
        {
            bool b = true;

            try
            {
                foreach (char chr in name)
                {
                    if (Char.IsNumber(chr))
                    {
                        b = false;
                        throw new Exception();
                    }
                }


                if (name.Length < 2)
                {
                    throw new Exception();
                }

                return true;
            }
            catch
            {
                if (name.Length < 2) Console.WriteLine("İsim ya da soyisim '2' karakterden az olamaz!\n", Console.ForegroundColor = ConsoleColor.Red);
                else if (!b) Console.WriteLine("İsim ya da soyisim 'rakam' içermemeli!\n", Console.ForegroundColor = ConsoleColor.Red);

                return false;
            }
        }
    }
}
