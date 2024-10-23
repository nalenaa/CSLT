using System;
using System.Security.Cryptography.X509Certificates;

internal class Exercise_02
{
    /*public static void Main()
    {

        //Question_01();
        //Question_02();
        //Question_03();
        //Question_04();

        /* public static void Question_01()
         {
             Console.Write("Nhap so a: ");
             int a = int.Parse(Console.ReadLine());
             Console.Write("Nhap so b: ");
             int b = int.Parse(Console.ReadLine());
             int c = a + b;
             Console.WriteLine($"{a}+{b}={c}");
         }
         public static void Question_02()
         {
             Console.Write("Nhap so a: ");
             int a = int.Parse(Console.ReadLine());
             Console.Write("Nhap so b: ");
             int b = int.Parse(Console.ReadLine());
             int c = a;
             a = b;
             b = c;
             Console.WriteLine($"b={b} va a={a}");
         }



         public static void Question_03()
         {
             Console.Write("Nhap so a: ");
             float a = Convert.ToSingle(Console.ReadLine());
             Console.Write("Nhap so b: ");
             float b = Convert.ToSingle(Console.ReadLine());
             float c = a * b;
             Console.WriteLine(c);
         }


         public static void Question_04()
         {
             Console.Write("Enter feet: ");
             demical feet = feet;
             demical meter = meter;

         }
        */
    }
}*/

        
    
 internal class Exercise_03
    {
        public static void Main()
        {
            Question_01();
            Console.ReadKey();
        }
        static void Question_01()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"For y = {y}, x ={x}");
            }
        }
    
    }
internal class Exercise_04
{
    public static void main()
    { Question_01();
        Console.ReadKey();
    }
    static void Question_01()
    {
        Console.WriteLine("Enter the radius of sphere: ");

        decimal radius = Convert.ToDecimal(Console.ReadLine());
        decimal surfaceArea = Convert.ToDecimal(Console.ReadLine());
        decimal volume = Convert.ToDecimal(Console.ReadLine());
        surfaceArea = 4 * Math.PI * (radius * radius);
        volume = 4 / 3 * Math.PI * (radius * radius * surfaceArea);
        Console.WriteLine("For surfaceArea ={surfaceArea},For volume = {volume} ");
    }






}

internal class Exercise_05();
{
    public static void Main();
    {   Question_03();
        Console.ReadKey();
       
    }

   /* {

        ///Gia va bien luan pt bac 1 : ã + b =0
        Console.Write("Nhap he so a: "); int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap he so b: "); int b = Convert.ToInt32(Console.ReadLine());
        if (a == 0)
            if (b == 0)
                Console.WriteLine("X tuy y");
            else
                Console.WriteLine("Vo Ly")
        else
            if (b == 0)
            Console.WriteLine("x=o");
        else
            Console.WriteLine("x= " + (-b / a));

    }
    ///Game doan so
    ///May tinh se nghi ngau nhien 1 so tư 1-10
    ///nguoi dung se doan xem so do la so nao
    ///Neu doan sai se tra ve
    */

    static void Question_03;
    {
        Random rnd = new Random();
        int comp_num = rnd.Next(0, 10) + 1;
        //hoi nguoi dung doan so
        //doan den khi nao dung thi thôi
        Console.Write("Ban doan so may? <1...10> ");
        int user_num = int.Parse(Console.ReadLine());
        if (user_num == comp_num) ; //kiem tra ket qua
        {
            Console.WriteLine("Ban da dung");
        }
        else
        {
            Console.WriteLine($"may tinh nghi so {comp_num.num}.
        }    
        
       
    }
    static void Question_03
}


    