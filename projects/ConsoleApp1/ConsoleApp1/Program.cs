using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class ClaEmployeeP
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            ClsEmployeeP employee = new ClsEmployeeP();
            Console.WriteLine("Enter you employee id");
            employee.PEmpId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your age");
            employee.PEAge=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name");
            employee.PEname = Console.ReadLine();
            Console.WriteLine("Enter your address");
            employee.PEaddress = Console.ReadLine();
            Console.WriteLine("Employee id   : " + employee.PEmpId);
            Console.WriteLine("Employee age  : " + employee.PEAge);
            Console.WriteLine("Employee name : " + employee.PEname);
            Console.WriteLine("Employee id   : " + employee.PEaddress);
        }
    }
}
