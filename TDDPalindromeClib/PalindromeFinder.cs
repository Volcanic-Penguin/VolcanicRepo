using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDPalindrome
{
    public class PalindromeFinder
    {

        public bool IsPalindrome(string value) {

            bool isStringPalindrome = false;

            if (value == null) 
                throw new ArgumentNullException("Error: Value must not be null");

            if (value.Length <= 1) 
                throw new ArgumentException("Ö är en palindrom tycker jag men inte läraren");

            if (Enumerable.SequenceEqual(value.ToCharArray(), value.ToCharArray().Reverse())) 
                isStringPalindrome = true;

            return isStringPalindrome;
        
        }

    }
}
