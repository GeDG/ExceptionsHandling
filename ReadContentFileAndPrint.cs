using System;
using System.IO;

class ReadContentFileAndPrint
{
    static void Main()
    {
        try
        {
            string file = File.ReadAllText(@"C:\WINDOWS\win.ini");
            Console.WriteLine(file);
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception : {0} : {1}", e.GetType().Name, e.Message); 
        }
    }
}

