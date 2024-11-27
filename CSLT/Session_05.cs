using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class Session_05()
    { 
        private static void Main(string[] args)
       
       {
            Console.WriteLine("please enter the quantity of items: n= ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            //Xuat ket qua(a);
            GenerateRandomArray(a);
            Console.WriteLine(a);
            InMang(a);
            /* Console.WriteLine("The new array is");
             AddingValue(a);*/
            Vidu_TimKiem();

        }
        static void GenerateRandomArray(int[]a)
        {
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(0, 100);

            } 

                
        }
        static void InMang(int[]a)
        {
            Console.Write("The array: ");
            foreach (int i in a) Console.WriteLine(i);
        }
        static void AddingValue(int[]a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += 2;
            }
            foreach (int i in a )
                {
                
                    Console.WriteLine($" {i}");
                
            }

        }
        


        //Check input xem có thuộc mảng ko
        static void Vidu_TimKiem()
        {
            Console.WriteLine("Nhap so luong phan tu cua mang: n = ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            GenerateRandomArray(a);
            Array.Sort(a);
            Console.WriteLine("Nhap so can tim kiem trong array: ");
            int socantim = int.Parse(Console.ReadLine());
            int pos = TimKiem_Linear(a, socantim);
            if (pos == -1)
                Console.WriteLine($"So {socantim} khong ton tai trong mang.");
            else
                Console.WriteLine($"{socantim} xuat hien tai vi tri {pos}");
            Console.WriteLine("Mang bao gom cac so sau: ");
            inMang(a);

        }
        static void inMang(int[]a)
        {
            Console.Write("The array: ");
            foreach (int i in a) Console.WriteLine( i);
        }
        static int TimKiem_Linear(int[]a, int socantim)
        {
            for (int i = 0;i < a.Length;i++)
            {
                if (a[i] == socantim)
                        return i;

            }
            return -1;
        }
    }
  
}
