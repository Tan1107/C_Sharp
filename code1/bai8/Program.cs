using System;

namespace bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             ep kieu la gi
            co may loai ep kieu
            1. chuyen doi kieu ngam dinh: chuyen doi kieu du lieu nho hon sang kieu du lieu lon hon
            vd : int intValue = 10;
                long longValue = intValue ====> longValue = 10; OK
            2. Chuyen doi kieu du lieu tuong minh: Thuong duoc dung de chuyen doi giua cac kiue du lieu co tinh chat tuong tu nhau
                cu phap : (<kieu du liue>)<bien can ep du lieu>
            neu du lieu can ep vuot qua mien gia tri cua kiue du lieu muon ep kieu thi chuong trinh se tu cat bit cho phu hop voi kha nag chua cu no(cat tu trai qua)
            3. su dung phuong thuc , lop ho tro san, Phuong thuc PARSE()
             */
            //int i = 300;
            //byte b = (byte)i;
            //Console.WriteLine(b);
            //double d = 2 / 3;
            //double k = (double)2 / 3;
            //double h = 1.0 * 2 / 3;
            //Console.WriteLine("d = {0}\nk = {1}\nh = {1}", d, k, h);
            // 
            int val = Convert.ToInt32("9");
            Console.WriteLine("moi ban nhap so A: ");
            string aStringNumber = Console.ReadLine();
            int aNumber = int.Parse(aStringNumber);
            Console.WriteLine("moi ban nhap so B: ");
            String bStringNumber = Console.ReadLine();
            int bNumber = int.Parse(bStringNumber);
            Console.WriteLine("tong cua 2 so la {0}\n hieu cua 2 so la {1}\n tich cua 2 so la {2}\n Thuong cua 2 so la {3}", aNumber + bNumber, aNumber - bNumber, aNumber*bNumber, (double)aNumber/bNumber); ;
        }
    }
}
