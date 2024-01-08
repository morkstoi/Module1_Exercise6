using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            int index = 0;  
            int maxLength = 0;
            for (int i = 0; i < stringArray.Length; i++)

            {
                if (stringArray[i].Length > maxLength)
                {
                    maxLength = stringArray[i].Length;
                    index = i;
                }

            }
            Console.WriteLine( "Самое длинное слово в предложении: {0}", stringArray[index]);
            Console.ReadKey();
        }
    }
}
