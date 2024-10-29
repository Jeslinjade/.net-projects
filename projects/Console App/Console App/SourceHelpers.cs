using Console_App;

internal static class SourceHelpers
{
    public static string Calculator(Operation o)
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
}