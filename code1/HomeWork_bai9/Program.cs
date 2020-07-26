using System;

namespace HomeWork_bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Viet chuong trinh nhap vao mot so tuong ung la nam, xuat ra man hinh nam vua nhap
            //va tuoi cua mot nguoi tuong ung voi nam vua nhap do.

            //int result;
            // Console.WriteLine("moi ban nhap nam sinh cua ban: ");
            // string yearStr = Console.ReadLine();
            // if (int.TryParse(yearStr, out result) == false)
            // {
            //     Console.WriteLine("nam ban nhap khong hop le, vui long nhap lai");
            // }
            // else
            // {
            //     int yearNumber = int.Parse(yearStr);
            //     int yearOld = 2020 - yearNumber;
            //     if(yearOld < 16)
            //     {
            //         Console.WriteLine("Ban {0}, Tuoi vi thanh nien", yearOld);
            //     }else if(yearOld >= 16 && yearOld < 18){
            //         Console.WriteLine("Ban {0}, Tuoi truong thanh", yearOld);
            //     }
            //     else
            //     {
            //         Console.WriteLine("Ban {0}, gia roi", yearOld);
            //     }

            // }
            // Console.ReadKey();

            //bai 2
            int result;
            Console.WriteLine("Moi ban nhap so 1, 2, 3 tuong ung voi keo, bua va bao");
            string strNumber = Console.ReadLine();
            if (int.TryParse(strNumber, out result) == false)
            {
                Console.WriteLine("du lieu nhap vao khong phai la so, vui long nhap lai");
            }
            else
            {
                int number = int.Parse(strNumber);
                Random r = new Random();
                int numberRandom = r.Next(1, 3);
                Console.WriteLine(numberRandom);
                if(number == numberRandom)
                {
                    Console.WriteLine("Nguoi choi va may hoa nha, vui long choi lai");
                }else if(number == 1)
                {
                    Console.WriteLine(numberRandom == 3 ? "Nguoi choi chien thang" : "May chien thang");
                }else if(number == 2)
                {
                    Console.WriteLine(numberRandom == 1 ? "nguoi choi chien thang" : "May chien thang");
                }else if(number == 3)
                {
                    Console.WriteLine(numberRandom == 2 ? "Nguoi choi chien thang" : "May chien thang");
                }
                else
                {
                    Console.WriteLine("Ban nhap so ngoai vung duoc chon, vui long nhap lai");
                }
            }
            Console.ReadKey();
        }
    }
}
