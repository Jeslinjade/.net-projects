using case_stdy_oops;
using System.Diagnostics;
using System.Drawing;

namespace case_stdy_oops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input for flavor and size
            Console.Write("Enter ice cream flavor: ");
            string flavour = Console.ReadLine();

            Console.Write("Enter ice cream size (Small/Medium/Large): ");
            string size = Console.ReadLine();

            // Create regular ice cream
            IceCream iceCream = new IceCream(flavour, size);
            iceCream.describe();

            // Ask if the user wants to add a special ingredient
            Console.Write("\nDo you want to add a special ingredient? (yes/no): ");
            string addSpecial = Console.ReadLine().ToLower();
            if (addSpecial == "yes")
            {
                Console.Write("Enter special ingredient: ");
                string specialIngredient = Console.ReadLine();

                // Create special ice cream using inheritance
                SpecialIceCream specialIceCream = new SpecialIceCream(flavour, size, specialIngredient);
                specialIceCream.describe();  // Polymorphism in action
            }

            // Ask if the user wants to modify any property
            Console.Write("\nWould you like to update the flavor? (yes/no): ");
            string updateFlavor = Console.ReadLine().ToLower();
            if (updateFlavor == "yes")
            {
                Console.Write("Enter new flavor: ");
                iceCream.SetFlavour(Console.ReadLine());
            }

            Console.Write("Would you like to update the size? (yes/no): ");
            string updateSize = Console.ReadLine().ToLower();
            if (updateSize == "yes")
            {
                Console.Write("Enter new size (Small/Medium/Large): ");
                iceCream.SetSize(Console.ReadLine());
            }

            // Describe the updated ice cream
            Console.WriteLine("\nUpdated ice cream details:");
            iceCream.describe();
        }
    }
}
