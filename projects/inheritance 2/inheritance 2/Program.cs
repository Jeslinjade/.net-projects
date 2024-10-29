// See https://aka.ms/new-console-template for more informationonsole.WriteLine("Hello, World!");
class ClsBranch
{
    int Bcode;string Bname, Baddress;
    public void GetBData()
    {
        Console.Write("Enter Branch Detail :");
        Bcode = Convert.ToInt32(Console.ReadLine());
        Bname = Console.ReadLine();
        Baddress = Console.ReadLine();
    }
    public void DisplayBData()
    {
        Console.WriteLine("Branch Code is " +Bcode);
        Console.WriteLine("Branch name is " + Bname);
        Console.WriteLine("Branch address is " + Baddress);
    }
    interface ClsEmployee
    {
        void GetEmpData();
        void DisplayEmpData();
    }
    class ClsManager : ClsBranch,ClsEmployee
    {
        int EmpId;
        string Ename;
        double Bonus, CA;
        public void GetEmpData()
        {
            Console.Write("Enter Manager Details:-");
            EmpId = Convert.ToInt32(Console.ReadLine());
            Ename = Console.ReadLine();
            Bonus = Convert.ToDouble(Console.ReadLine());
            CA = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayEmpData()
        {
            Console.WriteLine("manager id is:-" + EmpId);
            Console.WriteLine("manager name is:-" + Ename);
            Console.WriteLine("manager Bonus is:-" + Bonus);
            Console.WriteLine("manager CA is:-" + CA);
        }
    }
    class ClsMPLinheritance
    {
        static void Main(string[] args)
        {
            ClsManager obj1 = new ClsManager();
            obj1.GetBData();
            obj1.GetEmpData();
            obj1.DisplayBData();
            obj1.DisplayEmpData();
            Console.ReadLine();
        }
    }
}