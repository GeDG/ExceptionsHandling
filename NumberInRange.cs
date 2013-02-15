using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberInRange
{
    static void ReadNumber(int start, int end) 
    {
        int number = int.Parse(Console.ReadLine());
        if (number < start || number > end)
            throw new System.ArgumentOutOfRangeException();
    }
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            try
            {
                ReadNumber(5, 15);
                Console.WriteLine("Good Bye");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
