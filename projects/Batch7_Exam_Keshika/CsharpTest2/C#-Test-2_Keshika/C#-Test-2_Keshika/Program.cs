using System;

namespace C__Test_2_Keshika
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Input1: ");
            int input1 = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<int> numList = input.Split(' ').Select(int.Parse).ToList();

            List<int> result = USerProgramCode.GetElements(input1,numList);
            string lessValue = "";
            string greaterValue = "";

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] < input1)
                {
                    lessValue += result[i] + " ";
                }
                else if (result[i] > input1)
                {
                    greaterValue += result[i] + " ";
                }
            }
            if (result.Count == 1 && result[0] == -1)
            {
                Console.WriteLine("No element found");
            }
            else
            {
                Console.WriteLine($"The values less than {input1} are:");
                Console.WriteLine(lessValue);
                Console.WriteLine($"The values greater than {input1} are:");
                Console.WriteLine(greaterValue);
            }
        }
    }

}