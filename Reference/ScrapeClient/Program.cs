using ScrapeLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            String content = myScrape.ScrapeWepPage("http://wsb.pl", @"C:\Temp\web.txt");

            try
            {

                //string content = File.ReadAllText(@"C:\Temp\web.txt");
                Console.WriteLine(content);
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Coś poszło nie tak ...");
                Console.WriteLine($"Sprawdź czy istnieje plik {ex.FileName}.");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Coś poszło nie tak ...");
                Console.WriteLine("Sprawdź czy istnieje folder");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Coś poszło nie tak ...");
                Console.WriteLine($"Wystąpił błąd {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Kończę działanie !");
            }
            
            Console.Read();
        }
    }
}
