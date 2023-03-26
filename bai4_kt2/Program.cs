using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4_kt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                Console.Clear();
                Console.WriteLine("<----------------------INPUT---------------------->");
                Console.Write("Nhap mot so nguyen duong: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Boolean laSoNguyenTo;
                int tong = 0;

                Console.WriteLine("<----------------------OUTPUT--------------------->");
                for (int i = 2; i <= n; i++)
                {
                    laSoNguyenTo = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            laSoNguyenTo = false;
                            break;
                        }
                    }
                    if (laSoNguyenTo == true)
                    {
                        Console.WriteLine(i);
                        tong += i;
                    }
                }

                Console.WriteLine($"Tong cac so nguyen to tu 1 toi {n} la {tong}");
                Console.WriteLine();

                Console.WriteLine("<----------------------END------------------------>");
                Console.WriteLine("Nhan phim phim BAT KY de tiep tuc hoac phim ESC de ket thuc");
                Console.WriteLine();
                cki = Console.ReadKey();
            } while ((cki.Key != ConsoleKey.Escape));
        }
    }
}
