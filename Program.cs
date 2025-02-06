using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

class Program
{
    static async Task Main(string[] args)
    {

        string url = "https://example.com/";
        string filePath = "The.html";

        Console.WriteLine("(WebPage-Downloader)");
        Console.WriteLine("(Paste your url and hit Enter.)");

        url = Console.ReadLine();

        Console.WriteLine("(Press enter for downlode.)");
        Console.ReadLine();

        try 
        {

            WebClient client = new WebClient();
            string htmlContent = client.DownloadString(url);
            File.WriteAllText(filePath, htmlContent);
            Console.WriteLine("search this in you files: " + filePath);
            Console.WriteLine("Or press enter to open it.");
            Console.ReadLine();
            Process.Start("The.html");

        }
        catch(Exception ex)
        {

            Console.WriteLine("Could not download. (Enter to quit.) \n" + ex);
            Console.ReadLine();

        }
    }
}