using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_kt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<----------------------INPUT---------------------->");
            Console.Write("Nhap mot so nguyen duong: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int tong = 0;
            int tich = 1;

            for (int i = 1; i <= n; i++)
            {
                tich *= i;
                tong += tich;
            }

            Console.WriteLine("<----------------------OUTPUT--------------------->");
            Console.WriteLine($"Tong giai thua cac so tu 1 toi {n} la {tong}");
            Console.WriteLine();

            Console.WriteLine("<----------------------END------------------------>");
            Console.WriteLine("Nhan phim bat ki de ket thuc");
            Console.ReadKey();
        }
    }
}
