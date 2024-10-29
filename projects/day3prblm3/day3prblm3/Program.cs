// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//2 x 3 matrix
//int[,] myarray = new int[2,3];
//Console.WriteLine("Enter 6 integer values");
//outer loop for rows
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        myarray[i,j] = Convert.ToInt32(Console.ReadLine());
//    }
//}
//Console.WriteLine("The Elements in the array are:\n");
//for (int i = 0; i < 2; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        //myarray[i, j] = Convert.ToInt32(Console.ReadLine())
//        Console.Write($"{myarray[i,j]}\t");
//    }
//}
//int colsize;
//Console.WriteLine("Enter the column size");
//colsize=Convert.ToInt32(Console.ReadLine());
//int[,] myarray =new int[2,colsize];
//Console.WriteLine($"enter{2 * colsize}integer values");
//for (int  i = 0;  i <2; i++)
//{
//    for (int j = 0; j < colsize; j++)
//    {
//        myarray[i,j] = Convert.ToInt32(Console.Read());
//    }
//}
//Console.WriteLine("Array elements are\n");
//for (int i = 0; i <=1; i++)
//{
//    for (int j = 0; j < colsize; j++)
//    {
//        //myarray[i, j] = Convert.ToInt32(Console.Read());
//        Console.WriteLine(myarray[i, j] + " ");
//    }
//}
//int[][] jaggedArray = new int[4][];
//jaggedArray[0] = new int[2] { 5, 6 };
//jaggedArray[1] = new int[4] { 5, 6,7,8 };
//jaggedArray[2] = new int[6] { 5, 6 ,7,8,9,10};
//jaggedArray[3] = new int[8] { 5, 6 ,7,8,9,10,11,23};
////display the array element:
//for (int i = 0; i < jaggedArray.Length; i++)
//{
//    System.Console.Write($"Element({i+1}):");
//    for(int j=0;j<jaggedArray[i].Length; j++)
//    {
//        System.Console.Write(jaggedArray[i][j]+"\t" );
//    }
//    System.Console.WriteLine();
//}  
//dynamic x;
//x = "Hello";
//Console.WriteLine($"x value={x},x Type ={x.GetType()}");
//x = 34546;
//Console.WriteLine($"x={x},x Type ={x.GetType()}");
//x = false;
//Console.WriteLine($"x={x},x Type ={x.GetType()}");
//x = 345466476734735387;
//Console.WriteLine($"x={x},x Type ={x.GetType()}");
//x = 3.467889f;
//Console.WriteLine($"x={x},x Type ={x.GetType()}");
//x = 's';
//Console.WriteLine($"x={x},x Type ={x.GetType()}");
//Console.ReadLine();
//int? x = null;
//Console.WriteLine($"x value is {x}");
