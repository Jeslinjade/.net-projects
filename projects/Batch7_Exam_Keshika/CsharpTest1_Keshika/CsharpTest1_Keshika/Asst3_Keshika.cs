using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest1_Keshika
{
    public class Asst3_Keshika
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 4, 5, 5 };
            Array.Sort(arr);
            int n=arr.Length;
            int avg = (arr[n - 3] + arr[n - 2] + arr[n-1])/3;
            Console.WriteLine("Average of the largest 3 numbers in the array is "+avg);
        }

    }
}
