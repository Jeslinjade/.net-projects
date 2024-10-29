using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solve
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string[] input1, string input2)
        {
            List<string> employees = new List<string>();
            for (int i = 0; i < input1.Length; i++)
            {
                if (input2.ToLower() == input1[i].ToLower())
                {
                    employees.Add(input1[i - 1]);
                }
            }
            return employees.ToArray();
        }
    }
}
