using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
namespace HBAcademy
{
    internal class Bai5
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nhap dan so Los Angeles nam 1940: ");
            float danSoLosAngelesNam1940 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dan so Los Angeles nam 1950: ");
            float danSoLosAngelesNam1950 = float.Parse(Console.ReadLine());
            float tyLeDanLosAngeles = 100 * danSoLosAngelesNam1940 / danSoLosAngelesNam1950;
            Console.WriteLine("Nhap dan so NewYork nam 1940: ");
            float danSoNewYorkNam1940 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dan so NewYork nam 1950: ");
            float danSoNewYorkNam1950 = float.Parse(Console.ReadLine());
            float tyLeDanNewYork = 100 * danSoNewYorkNam1940 / danSoNewYorkNam1950;
            Console.WriteLine("Nhap dan so Chicago nam 1940: ");
            float danSoChicagoNam1940 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dan so Chicago nam 1950: ");
            float danSoChicagoNam1950 = float.Parse(Console.ReadLine());
            float tyLeDanChicago = 100 * danSoChicagoNam1940 / danSoChicagoNam1950;
            Console.WriteLine("Nhap dan so Detroit nam 1940: ");
            float danSoDetroitNam1940 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap dan so Detroit nam 1950: ");
            float danSoDetroitNam1950 = float.Parse(Console.ReadLine());
            float tyLeDanDetroit = 100 * danSoDetroitNam1940 / danSoDetroitNam1950;
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"|{"City",-15}|{"Year",-10}|{"Population",-15}|{"Year",-10}|{"Population",-15}|{"Change",-10}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"LosAngeles",-15}|{1940,-10}|{danSoLosAngelesNam1940,-15}|{1950,-10}|{danSoLosAngelesNam1950,-15}|{$"{tyLeDanLosAngeles:F2}" + "%"}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"NewYork",-15}|{1940,-10}|{danSoNewYorkNam1940,-15}|{1950,-10}|{danSoNewYorkNam1950,-15}|{$"{tyLeDanNewYork:F2}" + "%"}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"Chicago",-15}|{1940,-10}|{danSoChicagoNam1940,-15}|{1950,-10}|{danSoChicagoNam1950,-15}|{$"{tyLeDanChicago:F2}" + "%"}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine($"|{"Detroit",-15}|{1940,-10}|{danSoDetroitNam1940,-15}|{1950,-10}|{danSoDetroitNam1950,-15}|{$"{tyLeDanDetroit:F2}" + "%"}");
            Console.WriteLine("-------------------------------------------------------------------------------------");
        }
       
    }
}


