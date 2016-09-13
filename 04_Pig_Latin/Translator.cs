//using System;
//using System.Collections.Generic;
using System.Linq;

namespace _04_Pig_Latin
{
    internal class Translator
    {
        public Translator()
        {
            
        }

        public string Translate(string input)
        {
            string[] pigout = input.Split(' ');

            if (pigout.Length == 1)
            {
                return Piggify(pigout[0]);
            }
            else
            {
                for (int i = 0; i < pigout.Length; i++)
                {
                    pigout[i] = Piggify(pigout[i]);
                }
            }

            return string.Join(" ", pigout);
           

        }

        public string Piggify(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o' };
            string output;
            bool running = true;
            bool capitalize = false;
            string punctation = "";

            //Capitalization check
            if (input.Substring(0, 1) == input.Substring(0, 1).ToUpperInvariant())
            {
                capitalize = true;
            }
            //simple punctuation check
            if (IsPunctuation(input[input.Length - 1]) == true)
            {
                punctation = input[input.Length - 1].ToString();
                output = input.Substring(0, input.Length - 1);
            }
            else
            {
                output = input;
            }

            while (running)
            { 
            if (!vowels.Contains(char.Parse(output.Substring(0, 1))))
            {
                output = output.Substring(1) + output.Substring(0, 1);
            }
            else
                {
                    output += "ay";
                    running = false;
                }
            }

            if (capitalize == true)
            {
                output = output.Substring(0, 1).ToUpperInvariant()
                       + output.Substring(1).ToLowerInvariant();
            }
            return output + punctation;
        }

        public bool IsPunctuation(char c)
        {
            return char.IsPunctuation(c);
        }

        
    }
}