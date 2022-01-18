using System;

namespace Polindrom
{
    class Program
    {
        static void Main(string[] args)
        {

            string txt = Console.ReadLine();
            string str = string.Join(null, txt.ToLower());
            str = str.Replace(" ", string.Empty);
            int start = 0;
            int finish = str.Length - 1;
            bool res = Palindrom(str, start, finish);
            
            if (res)
            {
                Console.WriteLine("Is palindrom !");
            }
            else
                Console.WriteLine("Is NOT palindrom !");
        }

        public static bool Palindrom(string str, int start, int finish)
        {
            if (start == finish)
                return true;

            if (str[start] != str[finish])
                return false;

             if (str[start] == str[finish] && start < finish)
            {
                Palindrom(str, start+1, finish-1);
            }

            return true;
        }
    }
}
