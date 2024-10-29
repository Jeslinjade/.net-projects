using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CsharpTest1_Keshika
{
    public class Asst4_Keshika
    {
        public static void Main(string[] args)
        {
            int choice;
            int sum = 0;
            string responce = "y";
            Console.WriteLine("*****************************WELCOME TO MY CHOCOLATE STORE*************************************");
            Console.WriteLine("Please choose your Favourite chocolate: 1)Dairy Milk 2)Kit Kat 3)Munch ");
            while (responce== "y")
            {
                Console.WriteLine("Please type your options");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        sum += 50;
                        break;
                    case 2:
                        sum += 40;
                        break;
                    case 3:
                        sum += 30;
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
                Console.WriteLine("You want more(y/n)");
                responce = Console.ReadLine();
            }
            Console.WriteLine("Thanks for choosing my chocolate");
            Console.WriteLine("Your total amount is:-" + sum);
            Console.WriteLine("***********************************PAYMENT DONE**********************************************");
        }
    }
}
