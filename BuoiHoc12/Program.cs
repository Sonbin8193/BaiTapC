using System.Text;

namespace BuoiHoc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            NhanVien x = new NhanVien();
            x._name = "Sơn";
            x.Set_date("12/05/2023");
            Console.WriteLine(x.Get_date());
            //Tạo 10 nhân viên
            NhanVien[] array_NhanVien = new NhanVien[10];
            array_NhanVien[1] = new NhanVien { .Set_date("12/05/2023") };
            array_NhanVien[3] = new NhanVien { _name = "Hoàng" };
            array_NhanVien[0] = x;
            Console.WriteLine(array_NhanVien[1]._name);
            Console.WriteLine(array_NhanVien[1].Get_date());
        }
    }
}
