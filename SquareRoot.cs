using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SquareRoot
{
    public static double Sqrt(double value)
    {
        if (value < 0)
            throw new System.ArgumentOutOfRangeException("Sqrt for negative numbers is undefined!");
        return Math.Sqrt(value);
    }

    static void Main()
    {
        try
        {
            double s = double.Parse(Console.ReadLine());
            Sqrt(s);
            Console.WriteLine("Good Bye");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine("Error: " + ex.Message);
        }
    }
}

