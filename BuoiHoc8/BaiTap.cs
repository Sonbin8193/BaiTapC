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
        //Tạo Stack
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
        //Tạo danh sách đến lớp
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
        //Chia số chẵn và số lẻ
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
            else if (IsNumber(soDaNhap))
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
        //Nhập số và in ra số nhị phân
        public static void BaiTap6()
        {
            Console.WriteLine("Nhập một số nguyên N bất kỳ: ");
            int doDaiQueue = int.Parse(Console.ReadLine());
            Queue<int> daySo = new Queue<int>(doDaiQueue);

            Console.WriteLine($"Dãy số Nhị Phân từ 1 đến {doDaiQueue}: ");
            for (int i = 1; i <= doDaiQueue; i++)
            {
                daySo.Enqueue(i);
            }
            for (int i = 0; i < doDaiQueue; i++)
            {
                int xuLySo = daySo.Dequeue();
                Console.WriteLine( i+1 +" -> " + DecToBin(xuLySo));
            }
            string DecToBin(int a)
            {
                string b= Convert.ToString(a, 2).PadLeft(8,'0');
                return b;
            }
        }
        //Danh sách khách hàng đợi
        public static void BaiTap7()
        {
            Stack<int> soThuTu = new Stack<int>(100);
            Queue<string> danhSachHangCho = new Queue<string>();
            List<string> tenKhachHang = new List<string>();
            tenKhachHang.AddRange(new string[] { "Lan", "Hùng", "Phương", "Hoa", "Long", "Huy", "Phúc" });
            for (int i = 0; i < tenKhachHang.Count; i++)
            {
                soThuTu.Push(i);
                danhSachHangCho.Enqueue(tenKhachHang[i]);
            }
            //Kiểm tra hàng chờ
            Console.WriteLine("Nhập tên khách hàng cần tìm");
            string ten = Console.ReadLine();
            if (tenKhachHang.IndexOf(ten) !=-1)
            {
                Console.WriteLine($"Khách hàng {ten} đang xếp hàng vị trí thứ {tenKhachHang.IndexOf(ten) + 1}");
            } else
            {
                Console.WriteLine("Khách hàng không có tên trong hàng chờ");
            }
        }
        //Nhập danh bạ
        public static void BaiTap8()
        {
            Dictionary<string, string> danhBaDienThoai = new Dictionary<string, string>();
            danhBaDienThoai.Add("09277621", "An");
            danhBaDienThoai.Add("09277622", "Bình");
            danhBaDienThoai.Add("09277623", "Duy");
            danhBaDienThoai.Add("09277624", "Hùng");
            danhBaDienThoai.Add("09277625", "Phương");
            danhBaDienThoai.Add("09277626", "Thảo");
            danhBaDienThoai.Add("09277627", "Hoa");
            danhBaDienThoai.Add("09277628", "Huy");
            if (danhBaDienThoai.TryGetValue("09277628", out string ten))
            {
                Console.WriteLine($"Số điện thoại của {ten} có trong danh bạ");
            }
            foreach (var item in danhBaDienThoai)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            danhBaDienThoai.Clear();
        }
    }
}
