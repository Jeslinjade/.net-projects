using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTest1_Keshika
{
    public class Asst2_Keshika
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Salary:");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the numer of shifts you have done");
            int shifts = Convert.ToInt32(Console.ReadLine());
            int totsal = salary + ((2 * salary * shifts)/100);
            int food = (20 * totsal)/100;
            int travel = (30  * totsal)/100;
            int savings = totsal - (food + travel);
            Console.WriteLine("Salary       : " + salary);
            Console.WriteLine("Shifts       : " + shifts);
            Console.WriteLine("Total salary : " + totsal);
            Console.WriteLine("Amount spent for food   : " + food);
            Console.WriteLine("Amount spent for travel : " + travel);
            Console.WriteLine("Savings : " + savings);
        }
    }
}
