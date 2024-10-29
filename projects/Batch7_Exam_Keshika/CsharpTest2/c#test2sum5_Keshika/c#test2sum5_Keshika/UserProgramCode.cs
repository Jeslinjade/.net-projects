using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_test2sum5_Keshika
{
    public class UserProgramCode
    {
        public static string RemoveDuplicates(string input)
        {
            string result = ""; 
            foreach (char c in input)
            {
                if (!result.Contains(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}
