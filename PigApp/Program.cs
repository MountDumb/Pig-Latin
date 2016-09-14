using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_Pig_Latin;

namespace PigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator trans = new Translator();
            Console.WriteLine("Please write sentence for translation:\n\r ");

            string input = Console.ReadLine().Trim();
            input = trans.Translate(input);
            Console.WriteLine("Piggyfied version: " + input);
            Console.ReadKey();
            
        }
    }
}
