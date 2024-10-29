using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict
{
    internal class UserProgramCode
    {
        public static string[] getEmployee(string input1, string[] input2)
        {
            List<string> employees = new List<string>();

            // Process each employee entry
            for (int i = 0; i < input2.Length; i++)
            {
                // Find the first space to separate the name and designation
                int indexOfSpace = input2[i].IndexOf(' ');
                if (indexOfSpace == -1) // No space found, invalid input
                {
                    continue;
                }

                // Name is everything before the first space, designation is everything after
                string name = input2[i].Substring(0, indexOfSpace);
                string designation = input2[i].Substring(indexOfSpace + 1);

                // Check if the designation matches input1 (case-insensitive)
                if (designation.Equals(input1, StringComparison.OrdinalIgnoreCase))
                {
                    employees.Add(name);  // Add the employee's name if the designation matches
                }
            }

            return employees.ToArray(); // Convert List<string> to string[]
        }
    }

}
