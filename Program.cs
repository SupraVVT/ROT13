using System;

namespace ROT13
{
    class Program
    {
        static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var str = "cvpbPGS{arkg_gvzr_V'yy_gel_2_ebhaqf_bs_ebg13_jdJBFOXJ}";

            string rotString = "";

            char nextChar;
   
            foreach (var c in str)
            {
                var pos = alphabet.IndexOf(c);

                if (pos < 0)
                {
                    rotString += c;
                    continue;
                }

                else if (pos < 26)
                {
                    // Capital Letter
                    if (pos + 13 >= (alphabet.Length / 2))
                    {
                        var wrap = ((alphabet.Length / 2) - pos);
                        nextChar = alphabet[(13) - wrap];
                    }
                    else
                    {
                        nextChar = (alphabet[pos + 13]);
                    }
                }
                else
                {
                    // Small Letter
                    if (pos + 13 >= alphabet.Length)
                    {
                        var wrap = (alphabet.Length - pos);
                        nextChar = alphabet[(13 + 26) - wrap];
                    }
                    else
                    {
                        nextChar = (alphabet[pos + 13]);
                    }
                }
                
                rotString += nextChar;                
            }

            Console.WriteLine(rotString);
        }
    }
}
