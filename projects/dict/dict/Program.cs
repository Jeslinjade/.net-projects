using dict;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n;
        if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        string[] str = new string[n];
        for (int i = 0; i < n; i++)
        {
            str[i] = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(str[i]))
            {
                Console.WriteLine("Invalid Input");
                return;
            }
        }

        string find = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(find))
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        string[] op = UserProgramCode.getEmployee(find, str);
        int count = 0;

        // Check for invalid characters in the employee list
        foreach (string item in str)
        {
            foreach (char c in item)
            {
                if (!char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c))
                {
                    count++;
                }
            }
        }

        // Check for invalid characters in the 'find' designation
        foreach (char item in find)
        {
            if (!char.IsLetterOrDigit(item) && !char.IsWhiteSpace(item))
            {
                count++;
            }
        }

        if (count != 0)
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            if (op.Length == str.Length / 2)
            {
                Console.WriteLine($"All employees belong to the same {find} designation");
            }
            else if (op.Length == 0)
            {
                Console.WriteLine($"No employees for {find} designation");
            }
            else
            {
                foreach (string employee in op)
                {
                    Console.WriteLine(employee);
                }
            }
        }
    }
}

