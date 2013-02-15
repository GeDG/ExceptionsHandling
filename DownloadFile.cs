using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient webClient = new WebClient())
        {
            try
            {
                webClient.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", @"d:\Logo-BASD.jpg");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : {0} : {1}", e.GetType().Name, e.Message);
            }
            finally
            {
                webClient.Dispose();
            }
        }
    }
}

