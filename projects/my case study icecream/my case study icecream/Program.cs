// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Hello, World!");
public class IceCream
{
    string Flavour;
    double Price;
    string Size;
    public IceCream()
    {
        Flavour = "Chocolate";
        Price = 5.70;
        Size = "Medium";
    }
    public IceCream(string flavour)
    {
        Flavour = flavour;
        Price = 6.40;
        Size = "Medium";
    }
    public IceCream(string flavour,double price,string size)
    {
        Flavour = flavour;
        Price = price;
        Size = size;
    }
    public IceCream(IceCream otherIceCream)
    {
        Flavour = otherIceCream.Flavour;
        Price = otherIceCream.Price;
        Size = otherIceCream.Size;
    }
    public void describe()
    {
        Console.WriteLine($"This is a {Size} {Flavour} ice cream, priced at ${Price}.");
    }
        public double CalculateTotalPrice(int quantity)
    {
        return Price * quantity;
    }

    public double CalculateTotalPrice(int quantity, double discount)
    {
        double totalPrice = Price * quantity;
        return totalPrice - discount;
    }

    public static bool Compare(IceCream ic1, IceCream ic2)
    {
        return ic1.Flavour == ic2.Flavour && ic1.Price == ic2.Price && ic1.Size == ic2.Size;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IceCream defaultIceCream = new IceCream();
        defaultIceCream.describe();

        IceCream chocolateIceCream = new IceCream("Chocolate");
        chocolateIceCream.describe();

        IceCream customIceCream = new IceCream("Strawberry", 3.99, "Medium");
        customIceCream.describe();

        
        IceCream copiedIceCream = new IceCream(customIceCream);
        copiedIceCream.describe();
        
        double totalPrice = customIceCream.CalculateTotalPrice(3);
        Console.WriteLine($"Total price for 3 ice creams: ${totalPrice}");
        
        double totalPriceWithDiscount = customIceCream.CalculateTotalPrice(3, 1.50);
        Console.WriteLine($"Total price with discount: ${totalPriceWithDiscount}");
    }
}