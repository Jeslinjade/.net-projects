// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Welcome to XOXO Cafe...!!");
Console.WriteLine("Enter The Membership (gold/silver/bronze/nono");
string membership = Console.ReadLine().ToLower();
Console.WriteLine("Enter Order Price: $");
double price = Convert.ToDouble(Console.ReadLine());
double discount = 0;
if (membership == "gold" && price >= 50)
{
    discount = 0.20;
}
else if (membership == "silver" && price >= 30)
{
    discount = 0.10;
}
else if (membership == "bronze")
{
    discount = 0.05;
}
else
{
    discount = 0;
}
double totaldiscount = price * discount;
double FinalPrice = price - totaldiscount;
Console.WriteLine(FinalPrice);
