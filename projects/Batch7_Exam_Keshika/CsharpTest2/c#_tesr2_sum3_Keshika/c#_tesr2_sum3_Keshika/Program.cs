namespace c__tesr2_sum3_Keshika
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input1: ");
            int caliber = int.Parse(Console.ReadLine());

            Console.Write("Input2: ");
            int years = int.Parse(Console.ReadLine());

            double mileage = UserProgramCode.FindMileage(caliber, years);

            if (mileage != -1)
            {
                Console.WriteLine($"The mileage of the bike is {mileage}");
            }
        }
    }

}
