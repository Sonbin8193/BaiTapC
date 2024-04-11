using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc8
{
    public class BaiTap
    {
        public static void BaiTapStack()
        {
            Stack<string> congViec = new Stack<string>();
            congViec.Push("Đầu việc A");
            congViec.Push("Đầu việc B");
            congViec.Push("Đầu việc C");
            Console.WriteLine("Phan tu dau tien cua Stack là" + congViec.Peek());
            int soLuongViec = congViec.Count();
            for (int i = 0; i < soLuongViec; i++)
            {
                Console.Write("Các công việc trong Stack: " + congViec.Pop());
            }
            congViec.Push("Đầu việc A");
            congViec.Push("Đầu việc B");
            congViec.Push("Đầu việc C");
            string[] congViec_Array = congViec.ToArray();
            congViec.Pop();
            congViec.Clear();
        }

        public static void BaiTap4()
        {
          
            ArrayList thuTuSinhVien = new ArrayList();
            thuTuSinhVien.Add("Long");
            thuTuSinhVien.Add("Hoàng");
            thuTuSinhVien.Add("Phúc");
            thuTuSinhVien.Add("Sơn");
            thuTuSinhVien.Add("Tuấn");
            thuTuSinhVien.Add("Ngô");
            thuTuSinhVien.Add("Khoai");
            Queue thongTinSinhVien = new Queue(thuTuSinhVien);
            thuTuSinhVien.Remove("Sơn");
            //thongTinSinhVien.Clear();
            thongTinSinhVien = new Queue(thuTuSinhVien);
            Console.WriteLine(thuTuSinhVien.Count);
            for (int i = 0; i < thuTuSinhVien.Count; i++)
            {
                Console.WriteLine(thuTuSinhVien[i]);
            }
            for (int i = 0; i < thuTuSinhVien.Count; i++)
            {
                Console.Write("Người đến lớp thứ " + (i+1) + " là "  + thongTinSinhVien.Dequeue());
                Console.WriteLine();
            }
        }

        public static void BaiTap5()
        {
            Stack<int> soChan = new Stack<int>();
            Queue<int> soLe = new Queue<int>();
            nhaplai:
            Console.WriteLine("Nhập các số bất kỳ trên bàn phím (ấn phím \"a\" để dừng nhập): ");
            string soDaNhap = Console.ReadLine();
            Console.Clear();
            if (soDaNhap == "a")
            {
                goto hienthi;
            }
            if (IsNumber(soDaNhap))
            {
                int soDaNhap_int = int.Parse(soDaNhap);
                if (soDaNhap_int%2 ==0)
                {
                    soChan.Push(soDaNhap_int);
                    goto nhaplai;
                }
                else
                {
                    soLe.Enqueue(soDaNhap_int);
                    goto nhaplai;
                }
            }
            else
            {
                Console.WriteLine("Bạn vừa nhập sai định dạng, xin mời nhập lại số");
                goto nhaplai;
            }
        hienthi:
            Console.WriteLine("Hoàn thành");
            int chuoiSoLe = soLe.Count;
            int chuoiSoChan = soChan.Count;
            for (int i = 0; i < chuoiSoLe; i++)
            {
                Console.WriteLine("Các số lẻ vừa nhập là " + soLe.Dequeue());
            }
            for (int i = 0; i < chuoiSoChan; i++)
            {
                Console.WriteLine("Các số chẵn vừa nhập là " + soChan.Pop());
            }
            bool IsNumber(string pValue)
            {
                foreach (Char c in pValue)
                {
                    if (!Char.IsDigit(c))
                        return false;
                }
                return true;
            }
        }
        public static void BaiTap6()
        {
            Console.WriteLine("Nhập một số nguyên N bất kỳ: ");
            int doDaiQueue = int.Parse(Console.ReadLine());
            Queue<int> daySo = new Queue<int>(doDaiQueue);
            for (int i = 1; i <= doDaiQueue; i++)
            {
                daySo.Enqueue(i);
            }
            int DecToBin(int a)
            {

                return a;
            }
        }
    }
}
