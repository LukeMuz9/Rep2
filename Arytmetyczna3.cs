using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a;
        
        a = (int) inputValue();
        int b;
        
        b = (int) inputValue();
        int c;
        
        c = (int) inputValue();
        int d;
        
        d = (int) ((double) (a + b + c) / 3);
        Console.WriteLine(d);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
