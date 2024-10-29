namespace multitaskdelegate
{
    public delegate void Math(int x, int y);
        public class program
        {
            public void add(int x,int y)
        {
            Console.WriteLine("add:" + (x + y));
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("sub:" + (x - y));
        }
        public void mul(int x ,int y)
        {
            Console.WriteLine("mul:" + (x * y));
        }
        public void div(int x,int y)
        {
            Console.WriteLine("div:" + (x / y));
        }
        static void Main()
        {
            program obj = new program();
            Math m = new Math(obj.add);
            m += obj.sub;
            m += obj.mul;
            m += obj.div;
            m(100, 50);
            Console.WriteLine();
            m(625, 25);
        }

    }
}


