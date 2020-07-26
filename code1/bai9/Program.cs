using System;
using System.Runtime.CompilerServices;

namespace bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            // cau lenh re nhanh if else
            //bai tap giai phuong trinh Ax + B = 0;
            int result;
            Console.WriteLine("moi ban nhap so A");
            string strA = Console.ReadLine();
            Console.WriteLine("moi ban nhap so b");
            string strB = Console.ReadLine();
            if(int.TryParse(strA, out result) == false || int.TryParse(strB, out result) == false)
            {
                Console.WriteLine("Du lieu can nhap la so, vui long nhap lai: ");
            }
            else
            {
                int numberA = int.Parse(strA);
                int numberB = int.Parse(strB);
                Console.WriteLine("phuong trinh ban vua nhap la {0}x + {1} = 0", numberA, numberB);
                if(numberA == 0)
                {
                    Console.WriteLine("Du lieu nhap vao A phai khac 0, vui long nhap lai");
                }
                else
                {
                    Console.WriteLine("Phuong trinh co nghiem la: {0}", (double)-numberB / numberA);
                }
            }
            Console.ReadKey();
        }
    }
}
