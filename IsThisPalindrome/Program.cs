using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsThisPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string initialString = Console.ReadLine();
           string strippedString = initialString.Replace(" ","").ToLower();
            bool isPalindrome = true;
            for (int i = 0; i < strippedString.Length/2; i++)
            {
                if (strippedString[i] != strippedString[strippedString.Length - 1-i])
                {
                    isPalindrome = false;
                    break;  
                }
                 
            }
            if (isPalindrome)
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом.");
            }
            Console.ReadKey();  
        }
    }
}
