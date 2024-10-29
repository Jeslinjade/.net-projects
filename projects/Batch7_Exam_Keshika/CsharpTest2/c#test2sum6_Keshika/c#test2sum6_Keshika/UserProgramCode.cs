using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_test2sum6_Keshika
{
        public class UserProgramCode
        {
            public static string Reshape(string input, char separator)
            {
                
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                string reversedString = new string(charArray);

                
                string result = "";
                for (int i = 0; i < reversedString.Length; i++)
                {
                    result += reversedString[i];
                    
                    if (i < reversedString.Length - 1)
                    {
                        result += separator;
                    }
                }
                return result;
            }
        }
}
