using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class DETHITHU
    {
        private static void SampleTest()
        {
            Question_01();
            static void Question_01()
            {
                //Phan II C# co ban
                Console.WriteLine("Nhap ho va ten:");
                var a = Console.ReadLine();
                Console.WriteLine("Nhap chi so dien thang truoc: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Nhap chi so dien thang nay: ");
                float c = Convert.ToSingle(Console.ReadLine());
                float d = c - b;
                float e = d * 452.45f;
                float f = (10 * e) * 100;
                float g = e + 12426 + f;
                Console.WriteLine($"Hoa don tien dien:" +
                    $"\nKH: {a}" +
                    $"\nChi so cu: {b}" +
                    $"\nChi so moi: {c}" +
                    $"\nTieu thu: {d}" +
                    $"\nTien dien: {e}" +
                    $"\nTien thue dien ke 12426 d/thang" +
                    $"\nTien phu thu 10% tien dien: {f}" +
                    $"\nTong tien phai tra: {g}");

            }
        }

    }
}
