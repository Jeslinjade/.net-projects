using System.Collections.Immutable;

namespace CsharpTest1_Keshika
{
    public class Asst1_Keshika
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 5, 1, 8 };
            int len = arr.Length;
            Array.Sort(arr);
            int sum = arr[1] + arr[len - 2];
            Console.WriteLine($"Output = {sum}({arr[1]}+{arr[len-2]}={sum})");
        }
    }
}
