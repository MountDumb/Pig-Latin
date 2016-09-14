//using System;
//using System.Collections.Generic;
using System.Linq;

namespace _04_Pig_Latin
{
    public class Translator
    {
        public Translator()
        {
            
        }

        public string Translate(string input)
        {
            string[] pigout = input.Split(' ');
                       
                for (int i = 0; i < pigout.Length; i++)
                {
                    pigout[i] = Piggyfy(pigout[i]);
                }
        
            return string.Join(" ", pigout);
           

        }

        
        public string Piggyfy(string input)
        {
            char[] vowels = { 'a', 'e', 'i', 'o' };
            string output = "";
            string punctuation = "";
            bool running = true;
           
            //Punctuation check using PunctuationCheck() method defined below. 
            //Only handles punctuation at the end of a word.
            PunctuationCheck(input, out output, out punctuation);

            while (running)
            { 
            if (!vowels.Contains(char.Parse(output.Substring(0, 1).ToLowerInvariant())))
            {
                output = output.Substring(1) + output.Substring(0, 1);
            }
            else
                {
                    output += "ay";
                    running = false;
                }
            }

            //Capitalization check. Must be done after the word has been piggyfied.
            //output = Capitalize(input, output);
            output = Capitalize(output);

            return output + punctuation;
        }

        
      
        public void PunctuationCheck(string initialstring, out string strippedstring, out string punctuation)
        {
            int lchrstr= initialstring.Length - 1;

            if (char.IsPunctuation(initialstring[lchrstr]) == true)
            {
                punctuation = initialstring[lchrstr].ToString();
                strippedstring = initialstring.Substring(0, lchrstr);
            }
            else
            {
                punctuation = "";
                strippedstring = initialstring;
            }
        }

        public string Capitalize(string input)
        {
            foreach (var item in input)
            {
                if (char.IsUpper(item))
                {
                    return input.Substring(0, 1).ToUpperInvariant()
                               + input.Substring(1).ToLowerInvariant();
                }

            }
            return input;
        }
        //public string Capitalize(string initialstring, string finalstring)
        //{
            
        //    if (initialstring.Substring(0, 1) == initialstring.Substring(0, 1).ToUpperInvariant())
        //    {
        //            {
        //                return finalstring.Substring(0, 1).ToUpperInvariant()
        //                       + finalstring.Substring(1).ToLowerInvariant();
        //            }
        //    }
        //    else
        //    {
        //        return finalstring;
        //    }
        //}
        
        


    }
}