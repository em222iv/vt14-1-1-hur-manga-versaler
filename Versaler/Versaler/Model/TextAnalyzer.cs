using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

using System.Web;

namespace Versaler.Model
{
    static class TextAnalyzer
    {
        public static int GetNumberofCapitals(string Text) {

            int numberOfChars;
            Regex Reg = new Regex("[A-ZÅÄÖ]");
            numberOfChars = Reg.Matches(Text).Count;
            
            return numberOfChars;

           /* int numberOfChars = 0;
        
            char[] array = Text.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {  
                if (array[i] == Char.ToUpper(array[i]))
                {
                    numberOfChars++;
                }
            }
            return numberOfChars;*/
        }
    }
}