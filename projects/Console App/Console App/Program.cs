namespace Console_App;
    class Operation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public char opr { get; set; }
        public Operation(double num1, double num2, char op)
        {
            Num1 = num1;
            Num2 = num2;
            opr = op;
        }
    }
class Source
{
    public string ExceptionHandle(Operation o)
    {
        if (!(o.opr == '+' && o.opr == '-' && o.opr == '*' && o.opr == '/'))
        {
            return ("Invalid Operation");
        }
        else if (o.opr == '/' && o.Num2 == 0)
        {
            return ("Division by zero is not allowed");
        }
        else
        {
            return "No Exception found";
        }
    }
    public  string Calculator(Operation o)
    {
      
        switch (o.opr)
        {
            case '+':
                return "" + (o.Num1 + o.Num2);
            case '-':
                return "" + (o.Num1 - o.Num2);
            case '*':
                return "" + (o.Num1 * o.Num2);
            case '/':
                if (o.Num2 == 0)
                {
                    return ("Divide by Exception");
                }
                else
                {
                    return "" + (o.Num1 / o.Num2);
                }
            default:
                return ("ExceptionHandle");
        }
    }

    public static void Main(string[] args)
    {
        Operation o = new Operation(15, 67, '-');
        Source s=new Source();
        Console.WriteLine(s.Calculator(o));
    }
}