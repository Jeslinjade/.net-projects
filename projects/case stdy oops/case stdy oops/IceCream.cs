using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case_stdy_oops
{
    public class IceCream:IceCreamBase
    {
        public IceCream(string flavour, string size) : base(flavour, size)
        {
        }

        // Overriding describe method (Polymorphism)
        public override void describe()
        {
            Console.WriteLine($"This is a {GetSize()} {GetFlavour()} ice cream, priced at ${GetPrice()}.");
        }
    }
}
