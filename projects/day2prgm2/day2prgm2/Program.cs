// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//string[] names = new string[5];
//Console.WriteLine($"Enter {names.Length} names");
//for(int i = 0; i < names.Length; i++)
//{
//    names[i] = Console.ReadLine();
//}
//Console.WriteLine("The list of names are");
//foreach(var item in names)
//{
//    Console.WriteLine(item);
//}
//Array.Reverse(names);
//Console.WriteLine("the reversed order of names are:");
//foreach(var item in names)
//{
//    Console.WriteLine(item);
//}
//Array.Sort(names);
//Console.WriteLine("Sorted order of names are"); 
//foreach(var item in names)
//{
//    Console.WriteLine(item);
//}
int[] source = { 1, 2, 3, 4, 5 };
int[] destination = new int[3];
Array.Copy(source, 1, destination, 0, 3);
//Console.WriteLine($"Copied values:"+string.Join(", ", destination));
//foreach (int i in destination)
//{
//    Console.WriteLine(i);
//}
Array.Clear(destination, 2,1);
foreach (int i in destination)
{
    Console.WriteLine(i);
}