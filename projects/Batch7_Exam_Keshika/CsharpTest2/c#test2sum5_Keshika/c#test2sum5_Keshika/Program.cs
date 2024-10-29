namespace c_test2sum5_Keshika
{

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input1:");
            string input = Console.ReadLine();

            if (input.Length > 100)
            {
                Console.WriteLine("Input exceeds maximum length of 100 characters.");
                return;
            }

            string output = UserProgramCode.RemoveDuplicates(input);

            Console.WriteLine(output);
        }
    }

}
