//Given two input arrays, sort first array into ascending order and second array into descending order
//And multiply the first element of first array with last element of second array and second element of first array with second last of the second array and so on



using System.Collections.Immutable;

namespace Handsonday4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 4, 7, 9, 10 };
            int[] b = { 5, 6, 4, 3, 2 };
            Array.Sort(a);
            int temp=0;
            for(int i=b.Length-1; i>=0; i--)
            {
                for (int j = 0; i < b.Length; j++)
                {
                    temp = b[j];
                    b[j] = b[i];
                    b[i] = temp;
                    break;
                }
            }
            int[] mul =new int[5] ;
            for(int i=0;i<a.Length; i++)
            {
                
                    mul[i] = a[i] * b[i];
            }
            for(int i=0;i<mul.Length; i++)
            {
                Console.WriteLine(mul[i]);
            }
        }
    }
}
