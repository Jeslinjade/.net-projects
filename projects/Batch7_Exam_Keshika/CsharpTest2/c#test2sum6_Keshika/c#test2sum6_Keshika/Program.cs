namespace c_test2sum6_Keshika
{
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input:");
            string input = Console.ReadLine();
            //Console.WriteLine("Enter a character:");
            char separator = Console.ReadLine()[0];

            string output = UserProgramCode.Reshape(input, separator);

            Console.WriteLine(output);
        }
    }

}
