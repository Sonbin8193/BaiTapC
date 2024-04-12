using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc9
{
    internal class BaiTap
    {
        // Delay Task trong 5s
        public static async Task ThongBao()
        {
            int i=5;
            do {
                Console.WriteLine($"Chờ {i} giây...");
                await
                    Task.Delay(TimeSpan.FromSeconds(1));
                i--;
            }while(i>0);

            Console.WriteLine("Happy New Year");
        }
        // Tìm giá trị nhỏ nhất
        void NhapGiaTri()
        {
            Console.WriteLine("Nhập vào một số bất kỳ: ");
            int soNhap = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào một số bất kỳ: ");
            int soNhap2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào một số bất kỳ: ");
            int soNhap3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào một số bất kỳ: ");
            int soNhap4 = int.Parse(Console.ReadLine());
        }
        bool TimGiaTriNhoNhat(int a, int b)
        {
            if (a>b)
            {
                return true;   
            } else
            {
                return false;
            }
        }

        bool TimGiaTriNhoNhat2(ref int a, ref int b)
        {
            a = a - b;
            if (a>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool TimGiaTriNhoNhat3(int a, int b, out int min)
        {
            min = a - b;
            if (min >0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        int GiaTriTrungBinh(ref int a,ref int b,ref int c,ref int d, out int trungBinh) 
        {
            trungBinh = (a + b + c + d) / 4;
            return trungBinh;
        }
    }

}

