// See https://aka.ms/new-console-template for more informationConsole.WriteLine("Hello, World!");
interface Inter1
{
    void f1();
}interface Inter2
{
    void f1();
}
class c3 : Inter1, Inter2
{
    public void f1()
    {
        Console.WriteLine("this is an overriding function of inter1 and inter2 interfaces");
    }
}
class ClsInterface1
{
    static void Main(string[] args)
    {
        c3 obj1 = new c3();
        obj1.f1();
        Console.Read();
    }
} 