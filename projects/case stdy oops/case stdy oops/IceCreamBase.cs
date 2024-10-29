using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_stdy_oops
{
    public abstract class IceCreamBase:IIceCream
    {
        // Encapsulated private fields
        private string Flavour;
        double Price;
        private string Size;

        // Public getters and setters (Encapsulation)
        public string GetFlavour() => Flavour;
        public void SetFlavour(string flavour) => Flavour = flavour;

        public double GetPrice() =>Price;
        public void SetPrice(double price)
        {
            if (price > 0)
                Price = price;
        }

        public string GetSize() => Size;
        public void SetSize(string size)
        {
            Size = size;
            SetPriceBySize(size);
        }

        // Constructor to initialize the ice cream object
        public IceCreamBase(string flavour, string size)
        {
            Flavour = flavour;
            SetSize(size);
        }

        // Abstract method to be implemented in derived classes (Abstraction)
        public abstract void describe();

        // Method to calculate total price
        public double CalculateTotalPrice(int quantity)
        {
            return Price * quantity;
        }
        private void SetPriceBySize(string size)
        {
            switch (size.ToLower())
            {
                case "small":
                    SetPrice(2.50);
                    break;
                case "medium":
                    SetPrice(3.50);
                    break;
                case "large":
                    SetPrice(4.50);
                    break;
                default:
                    Console.WriteLine("Invalid size, setting price to default (Medium price).");
                    SetPrice(3.50);
                    break;
            }
        }

    }
}
