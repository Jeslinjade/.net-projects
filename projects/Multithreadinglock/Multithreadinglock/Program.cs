using System.Threading;
namespace Multithreadinglock
{
    class Threaddemo
    {
        Thread t1, t2, t3;
        public Threaddemo()
        {
            t1 = new Thread(Display);
            t2 = new Thread(Display);
            t3 = new Thread(Display);
            t1.Start();t2.Start();t3.Start();
        }
        public void Display()
        {
            lock (this){
                Console.WriteLine("C# is");
                Thread.Sleep(5000);
                Console.WriteLine("object oriented");
            }
            
        }
        static void Main()
        {
            Threaddemo obj= new Threaddemo();
            obj.t1.Join();obj.t2.Join();obj.t3.Join();
            Console.ReadLine();
        }
    }
}
