namespace Delegate;
public class Program
{
    Delegate int CalcDelegate(int num1, int num2);
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 5;
        Calculate(num1, num2, '+');
        Calculate(num1, num2, '-');
        Calculate(num1, num2, '*');
        Calculate(num1, num2, '/'); 
    }
    static void Calculate(int num1,int num2,CalcDelegate del)
    {
        int result = del(num1, num2);
        Console.WriteLine("Result: " + result);
    }
    static int Add(int num1, int num2)
    {
        Console.WriteLine("Add");
        return num1 + num2;
    }
    static int subtract(int num1, int num2 )
    {
        Console.WriteLine("Subtract");
        return num1 - num2;
    }
    static int Mulltiply(int num1, int num2)
    {
        Console.WriteLine("Multiply");
        return num1 * num2;
    }
    static int Divide(int num1, int num2)
    {
        Console.WriteLine("Divide");
        return num1 / num2;
    }
    

}