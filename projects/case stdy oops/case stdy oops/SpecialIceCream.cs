using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_stdy_oops
{
    internal class SpecialIceCream:IceCream
    {
        private string SpecialIngredient;  // New property for special ice cream

        // Constructor for SpecialIceCream
        public SpecialIceCream(string flavour, string size, string specialIngredient)
            : base(flavour, size)
        {
            SpecialIngredient = specialIngredient;
        }

        // Overriding describe method to add special ingredient detail (Polymorphism)
        public override void describe()
        {
            base.describe();  // Call base method
            Console.WriteLine($"This ice cream has a special ingredient: {SpecialIngredient}");
        }
    }
}
