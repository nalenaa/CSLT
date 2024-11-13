using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{


    internal class Session_07
    {/*
        public static void Main()
        {
            int[][] a;
            Console.Write("Nhap so dong: "); int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            NhapMangTuDong(a,rows);
            InMang(a);
        }

        private static void InMang(int[][] a)
        {
           for ( int i =0; i<a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
           
        }

        private static void NhapMangTuDong(int[][] a, int rows)
        {
            Random random = new Random();
            //rows = a.len
            for (int i = 0; i < a.Length;i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols];
                for (int j =0; j < cols; j++)
                {
                    // Console.Write($"a[{i}][{j}] = ");
                    //a[i][j] = int.Parse(Console.ReadLine());
                    a[i][j] = random.Next(100);

                }
            }    
        }
    }
}
    
        //BANG1CHIEU
        /*
        
        /*
        static void SearchLinear(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                }
            }
        */



        /* {
         static void NhapMangBangCom()
         {
             Console.WriteLine("Nhap so dong N: "); int N = int.Parse(Console.ReadLine());
             Console.WriteLine("Nhap so cot M: "); int M = int.Parse(Console.ReadLine());
             //tao mang 2 chieu
             int [,] a = new int[N, M];
             for (int i = 0; i < a.GetLength(0); i++)
             {
                 for (int j = 0; j < a.GetLength(1); j++)
                 {
                     Console.WriteLine($"a[{i}], [{j}]= ");
                     a[i, j] = int.Parse(Console.ReadLine());
                 }
                 Console.WriteLine();
             }
         }


             NhapMangBangCom(a, N, M);

             XuatMang(a);

         }
     static void XuatMang(int[,] a)
     {
         for (int i = 0; i < a.GetLength(0); i++)
         {
             for (int j = 0; j < a.GetLength(1); j++)
             {
                 Console.WriteLine(a[i, j] + "/t");
             }
             Console.WriteLine();
         }
     }
     */
    }
}
       

            //BANGDACHIEU





    

    

