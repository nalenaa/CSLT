using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class Session_03
    {
        static void Exercise_03()
        {

            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            /*
                static void Question_01()
                {
                    Console.WriteLine("Enter number a: ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter number b: ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    int x = 0;
                    Console.WriteLine($"a*b={a*b}");
                    Console.WriteLine($"a-b={a-b}");
                    Console.WriteLine($"a*b={a*b}");
                    Console.WriteLine($"a/b={a / b}");


                }
            static void Question_02()
            {
                Console.WriteLine("Enter value for y: ");
                int y = int.Parse(Console.ReadLine());
           
                if (-5<y)
                {
                    if (y < 5)
                    {
                        float x = y ^ 2 + 2 * y + 1;
                        Console.WriteLine($"voi y = {y} => x={x}");
                    }
                    else if (y>5)
                    {
                        Console.WriteLine("khong thoa dieu kien");
                    }

                else
                    { Console.WriteLine("Khong thoa dieu kien"); }



                    

                }
            static void Question_03()


            {
                Console.WriteLine("Enter distance in km: ");
                float distance = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter time in hours: ");
                float hours = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter time in minutes: ");
                float minutes = Convert.ToSingle(Console.ReadLine());

                float time = hours + minutes / 60;
                float speed_km = distance / time;
                Console.WriteLine($"your speed is {speed_km}km/h");

            }
            static void Question_04()
            {
                Console.WriteLine("Enter the radius of sphere: ");
                float radius = Convert.ToSingle(Console.ReadLine());
                double pi  = Math.PI;
                double Volume =  (4/3) * (pi * radius);
                Console.WriteLine($"The volume of the entered sphere is {Volume}");
                



            }
            static void Question_05()
            {
                Console.WriteLine("Enter a symbol: ");
                char symbol = Convert.ToChar(Console.ReadLine());

                if ("aeiouAEIOU".Contains(symbol))
                {
                    Console.WriteLine("This is a vowel");
                }
                else if ((symbol >= '0') && (symbol <= 9))
                {
                    Console.WriteLine("This is a digit");

                }
                else
                {
                    Console.WriteLine("Its another symbol");
                }




            }*/

            /*Question_06();
            static void Question_06()
            {
                Console.WriteLine("Enter a number: ");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                { Console.WriteLine("this is a even number"); }
                else
                {
                    Console.WriteLine("This is an odd number: ");
                }
            }
            Question_07();
            static void Question_07()
            {
                Console.WriteLine("Enter the first number a: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number b: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the third number c: ");
                float c = float.Parse(Console.ReadLine());
                if ((a > b) && (a > c))
                {
                    Console.WriteLine("a is the largest");

                }
                else if ((b > a) && (b > c))
                {
                    Console.WriteLine("b is the largest");
                }
                else
                {
                    Console.WriteLine("c is the largest");
                }
            Question_07();
            static void Question_07()
            {
                Console.WriteLine("Enter the X poin: ");
                int X = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Y point: ");
                int Y = int.Parse(Console.ReadLine());
                if ((X > 0) && (Y > 0))
                {
                    Console.WriteLine($"The coordinate point ({X},{Y}) lies in the first quandrant");
                }
                else if ((X < 0) && (Y > 0))
                {
                    Console.WriteLine($"The coordinate point ({X},{Y}) lies in the second quandrant");

                }
                else if ((X < 0) && (Y < 0))
                {
                    Console.WriteLine($"The coordinate point ({X},{Y}) lies in the third quandrant");
                }
                else
                {
                    Console.WriteLine($"The coordinate point({X},{Y})lies in the third quandrant");











                }


            }

            Question_08(); //Write a program to read 5 num then find the average and sum
                static void Question_08()
            {
                Console.WriteLine("Enter the first number: ");
                float a = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number: ");
                float b = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the 3rd number: ");
                float c = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the 4th number: ");
                float d = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter the 5th number: ");
                float e = Convert.ToSingle(Console.ReadLine());
                float f = a + b + c + d + e;
                float g = f / 5;
                Console.WriteLine($"The sum of 5 given num is {f} and the average is {g}");



            }
            Question_09(); //write a program to read 10 num given then find the average or sum
            static void Question_09()
            {
                int sum = 0; // lưu lại tổng số ban đầu trước khi cộng
                int count = 10; // đại diện cho số lượng số cần nhập
                Console.WriteLine($"Enter {count} numbers: ");
                for (int i = 0; i < 10; i++) // điều kiện vòng lặp
                {
                    Console.WriteLine($"Number {i + 1}: ");
                    sum += int.Parse(Console.ReadLine());

                } 
                double average = sum/(double)count;
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
                    
                    
            }

            Question_10();//write a program to make a multiplication table for a number
            static void Question_10()
            {
                Console.WriteLine("Enter a number to multipli: ");
                int n = int.Parse(Console.ReadLine());
                int i = 1;
                Console.WriteLine($"Multiplication table of {n}: ");
                while ( i <= 10)
                {
                    Console.WriteLine($" {n} x {i} = {n * i} ");
                    i++;
                }
            }
            
            Question_11();//rewrite Q10 for better memorising
            static void Question_11()
            {
                Console.WriteLine("Enter a number to multiply: ");
                int n = int.Parse(Console.ReadLine());
                int i = 1;
                Console.WriteLine("The multiplication table of it is: ");
                while(i<10)
                {
                    Console.WriteLine($"{n}x{i}= {n * i}");
                    i++;
                }
            }
            */
        }

    }
}



