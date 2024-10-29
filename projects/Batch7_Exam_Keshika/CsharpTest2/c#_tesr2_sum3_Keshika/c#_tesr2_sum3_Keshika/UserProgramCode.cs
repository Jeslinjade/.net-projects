using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__tesr2_sum3_Keshika
{
    public class UserProgramCode
    {
        public static double FindMileage(int caliber, int years)
        {
            
            if (caliber < 100)
            {
                Console.WriteLine("Invalid caliber");
                return -1; 
            }

            
            if (years < 0 || years > 20)
            {
                Console.WriteLine("Invalid years");
                return -1; 
            }
            double promisedMileage;

            if (caliber >= 100 && caliber <= 125)
            {
                promisedMileage = 75;
            }
            else if (caliber >= 126 && caliber <= 135)
            {
                promisedMileage = 70;
            }
            else if (caliber >= 136 && caliber <= 150)
            {
                promisedMileage = 60;
            }
            else if (caliber >= 151 && caliber <= 200)
            {
                promisedMileage = 50;
            }
            else if (caliber >= 201 && caliber <= 220)
            {
                promisedMileage = 35;
            }
            else
            {
                Console.WriteLine("Invalid caliber");
                return -1;
            }

            double mileageReduction;
            if (years <= 2)
            {
                mileageReduction = promisedMileage * 0.10; 
            }
            else if (years <= 4)
            {
                mileageReduction = promisedMileage * 0.15; 
            }
            else
            {
                mileageReduction = promisedMileage * 0.20; 
            }

            double finalMileage = promisedMileage - mileageReduction;
            return finalMileage;
        }
    }
}
