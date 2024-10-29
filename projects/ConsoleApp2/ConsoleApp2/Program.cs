// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your name");
string name = Console.ReadLine();
Console.WriteLine("Enter your Roll number");
string roll_number = Console.ReadLine();
Console.WriteLine("Enter your sub1 mark");
int sub1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your sub2 mark");
int sub2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your sub3 mark");
int sub3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your sub4 mark");
int sub4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter your sub5 mark");
int sub5 = Convert.ToInt32(Console.ReadLine());

if (sub1 >= 35 && sub2 >= 35 && sub3 >= 35 && sub4 >= 35 && sub5 >= 35)
{
    int avg=(sub1+sub2+sub3+sub4+sub5)/5;
    if (avg >= 90&&avg<=100)
    {
        Console.WriteLine("Excellent");
    }
    else if (avg >= 80 && avg < 90)
    {
        Console.WriteLine("Very Good");
    }
    else if (avg >= 70 && avg < 80)
    {
        Console.WriteLine("Good");
    }
    else if (avg >= 60 && avg < 70)
    {
        Console.WriteLine("Fair");
    }else if (avg >= 50 && avg < 60)
    {
        Console.WriteLine("Need Improvement");
    }else if(avg >= 40 && avg < 50)
    {
        Console.WriteLine("Below average");
    }
    else
    {
        Console.WriteLine("Put more effort");
    }
}
else
{
    Console.WriteLine("You have failed");
}