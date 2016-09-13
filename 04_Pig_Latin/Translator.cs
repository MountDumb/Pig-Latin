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
                       
                for (int i = 0; i < pigout.Length; i++)
                {
                    pigout[i] = Piggify(pigout[i]);
                }
        
            return string.Join(" ", pigout);
           

        }

        
        public string Piggify(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o' };
            string output = "";
            string punctuation = "";
            bool running = true;
            bool capitalize = false;

            //Punctuation check using PunctuationCheck() method defined below. 
            //Only handles punctuation at the end of a word.
            PunctuationCheck(input, out output, out punctuation);

            //Capitalization check
            if (input.Substring(0, 1) == input.Substring(0, 1).ToUpperInvariant())
            {
                capitalize = true;
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
            return output + punctuation;
        }

        
      
        public void PunctuationCheck(string input, out string output, out string punctuation)
        {
            int lastcharacterininput = input.Length - 1;

            if (char.IsPunctuation(input[lastcharacterininput]) == true)
            {
                punctuation = input[lastcharacterininput].ToString();
                output = input.Substring(0, lastcharacterininput);
            }
            else
            {
                punctuation = "";
                output = input;
            }
        }  


    }
}