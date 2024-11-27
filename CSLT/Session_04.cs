using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT
{
    internal class Session_04
    {
        public static void Exercise_04()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //GameTaiXiu();
            GameDoanSo();
            /*static void Question_01()
            {
                Console.WriteLine("Luu y khong nhap so giong nhau" +
                    "\n Nhap so thu nhat: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so thu hai: ");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap so thu ba: ");
                int c = int.Parse(Console.ReadLine());

                if ( a>b)
                {
                    if (b>c)
                    {
                        Console.WriteLine($"{a} la so lon nhat ");

                    }
                    else if (c>a)
                    {
                        Console.WriteLine($"{c} la so lon nhat");

                    }
                }
                else if (a<b)
                {
                    if (b < c)
                    { Console.WriteLine($"{c} la so lon nhat"); }
                    else if (c < a) { Console.WriteLine($"{b} la so lon nhat"); }
                }
            
            }
            static void Question_02() //tim so giai thua cua input
            {
                Console.WriteLine("Nhap sp can tinh giai thua: ");
                int num = int.Parse(Console.ReadLine());
                long res = Factorial(num);
                Console.WriteLine($"Ket qua: {num}! ={res}");
            }
            static long Factorial(int num)
            {
                if (num<0) {
                    throw new ArgumentException("Factorial is not defined for negative number.");

            }
            
            public static void Question_03()
            //kiểm tra xem 1 số có phải là số nguyên tố hay không
            {
                Console.Write("Nhap so can kiem tra (x > 1): ");
                int num = int.Parse(Console.ReadLine());
                if (IsPrime(num))
                {
                    Console.WriteLine($"{num} la so nguyen to.");
                }
                else
                {
                    Console.WriteLine($"{num} khong phai la so nguyen to.");
                }
            }
            // Hàm kiểm tra số nguyên tố
            static bool IsPrime(int num)
            {
                for (int i = 2; i <= Math.Sqrt(num); i++) // Kiểm tra ước của num từ 2 đến căn bậc hai của num
                {
                    if (num % i == 0)
                    {
                        return false; // Nếu tìm thấy ước của num, thì num không phải là số nguyên tố
                    }
                }
                return true; // Nếu không tìm thấy ước nào, thì num là số nguyên tố
            }
            static void printPrimenumberUnderN(int n)
            {
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                        Console.Write($" {i} ");
                }
            }
            public static void Question_04a() //Xuất ra các số nguyên tố đứng trước 1 số cho trước
            {
                Console.Write("Nhap so n = ");
                int n = int.Parse(Console.ReadLine());
                printPrimenumberUnderN(n);
            }

            static void GameTaiXiu()
            {
                static void Main()
                {
                    game_engine();
                }
                static int rollDice()
                {
                    Random rnd = new Random();
                    int die_1 = rnd.Next(6) +1;
                    int die_2 = rnd.Next(6) + 1;
                    int die_3 = rnd.Next(6) + 1;
                    int sum_of_dice = die_1 + die_2 + die_3;
                    return sum_of_dice;


                }
                static void playOneRound()
                {
                    int com_dice = rollDice();
                    Console.WriteLine("Ban doan Tai hay Xiu: <T/X>");
                    string user_guessing = Console.ReadLine();
                    if (user_guessing == "T")
                    {
                        if (com_dice >= 10)
                            Console.WriteLine("Ban Thang");
                        else Console.WriteLine("Ban Thua");

                    }   
                    else if (user_guessing == "X")
                    {
                        if (com_dice <= 10)
                            Console.WriteLine("Ban Thang");
                        else Console.WriteLine("Ban Thua");
                        
                    }
                    else
                    {
                        Console.WriteLine("Vui long chon dung dinh dang");
                    }
                    
                        
                }
                static void game_engine()
                {
                    do
                    {
                        playOneGround();
                        Console.WriteLine("Ban co muon choi lai lan nua khong? <C/K>");
                        string choice = Console.ReadLine();
                        if (choice == "K")
                            break;
                    } while (true);
                    Console.WriteLine("Mai choi tiep nhe!");
                        
                }*/
            static void GameDoanSo()
            {
                do
                {
                    Random rnd = new Random();
                    int comp_num = rnd.Next(0, 10) + 1;
                    //hoi nguoi dung doan so
                    //doan den khi nao dung thi thoi và dem so lan phai doan
                    int count = 0;
                    bool isContinue = true;
                    do
                    {
                        count++;
                        Console.WriteLine("Ban doan so may? <1...10>");
                        int user_num = int.Parse(Console.ReadLine());
                        //kiem tra ket qua
                        if (user_num == comp_num)
                        {
                            Console.WriteLine($"Ban da doan dung sau {count} lan! That gioi");
                            isContinue = false;
                        }
                        else
                        {
                            if (user_num > comp_num)
                                Console.WriteLine("Nhap so khac nho hon");
                            else
                                Console.WriteLine("Nhap so khac lon hon");
                        }
                    } while (isContinue);
                    Console.WriteLine("________________________");
                    Console.Write("Ban muon choi tiep khong? <C/K>: ");
                    string reply = Console.ReadLine();
                    if (reply.ToUpper().Equals("K"))
                    {
                        Console.WriteLine("End Game. Hen gap lai lan sau!");
                        return;
                    }
                } while (true);
            }
        }


    }
}

