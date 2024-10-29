Getting input and printing 
int a;
float b;
char c;
string name;
double d1;
decimal d2;
Console.WriteLine("Enter the integer value");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the float value");
b = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the char value");
c = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Enter the string name");
name = Console.ReadLine();
Console.WriteLine("Enter the double value");
d1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter the decimal value");
d2 = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine($"Integer value = {a}\nfloat value = {b}\nCharacter = {c}\nString value = {name}\nDouble value = {d1}\nDecimal value = {d2}");

Output:

Enter the integer value
5
Enter the float value
5.5
Enter the char value
g
Enter the string name
Keshh
Enter the double value
78707
Enter the decimal value
0.0000002
Integer value = 5
float value = 5.5
Character = g
String value = Keshh
Double value = 78707
Decimal value = 0.0000002