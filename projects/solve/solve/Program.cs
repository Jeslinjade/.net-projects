namespace solve
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < n; i++)
            {
                str[i] = Console.ReadLine();
            }
            string find = Console.ReadLine();
            string[] op = UserProgramCode.getEmployee(str,find);
            int count = 0;
            foreach (string item in str)
            {
                foreach (char c in item)
                {
                    if (!char.IsLetterOrDigit(c))
                    {
                        count++;

                    }
                }

            }
            foreach (char item in find)
            {
                if (!char.IsLetterOrDigit(item) && (!char.IsWhiteSpace(item)))
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine(value: "Invalid Input");
            }
            else
            {
                if (op.Length == str.Length / 2)
                {
                    Console.WriteLine(format: "All employees belong to the same {0} designation", find);
                }
                else if (op.Length == 0)
                {
                    Console.WriteLine(format: "No employees for {0} designation", find);
                }
                else
                {
                    foreach(string item in op)
                    {
                        Console.WriteLine(item);
                    }
                }
              
            }
            Console.ReadLine();
        }
    }
}