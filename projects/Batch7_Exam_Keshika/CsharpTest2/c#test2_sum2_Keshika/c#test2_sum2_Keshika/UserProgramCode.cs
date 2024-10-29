using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_test2_sum2_Keshika {

public class USerProgramCode
{
    public static string NegativeString(string input)
    {
        string result = "";
        int i = 0;

        while (i < input.Length)
        {
            if (i + 1 < input.Length && input[i] == 'i' && input[i + 1] == 's' &&
                (i == 0 || !char.IsLetter(input[i - 1])) &&
                (i + 2 == input.Length || !char.IsLetter(input[i + 2])))
            {

                result += "is not";
                i += 2;
            }
            else
            {

                result += input[i];
                i++;
            }
        }

        return result;
    }
}
}
