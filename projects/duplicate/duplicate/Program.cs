// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Hello, World!");
int[] num = { 1, 2, 3, 2, 4, 1, 5, 3, 6, 1 };
int Count = 0;
for(int i = 0; i < num.Length; i++)
{
    Count = 0;
    for (int j = 0; j < num.Length; j++)
    {
        if (num[i] == num[j])
        {
            Count++;
            num[j] = -1;
        }

    }

    Console.WriteLine($"the number {num[i]} has occured {Count} number of times");
}