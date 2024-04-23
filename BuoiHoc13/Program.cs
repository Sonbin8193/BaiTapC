using System.Text;

namespace BuoiHoc13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Bài tập nạp chồng toán tử
            //HinhChuNhat a = new HinhChuNhat();
            //a.ChieuDai = 10;
            //a.ChieuRong = 20;
            //HinhChuNhat b = new HinhChuNhat();
            //b.ChieuDai = 15;
            //b.ChieuRong = 30;
            //HinhChuNhat c = new HinhChuNhat();
            //c = a + b;
            //Console.WriteLine(a.TinhDienTich());
            //Console.WriteLine(b.TinhDienTich());
            //Console.WriteLine(c.TinhDienTich());

            //Bài Tập Delagate
            Person NV1 = new Person("Sơn", "12052005", 100000,1);
            Person.FuncDelegate personSalary = new Person.FuncDelegate(NV1.TangLuong);
            Person.ActionDelegate personHello = new Person.ActionDelegate(NV1.HienThiTen);
            Person.PredicateDelegate personGender = new Person.PredicateDelegate(NV1.KiemTraGioiTinh);
            Console.WriteLine("Thưởng của {0} là {1}",NV1.Name1,personSalary(NV1.Salary1,out double thuong));
            personHello(NV1.Name1);
            string gioitinh = personGender(NV1.Gender)?"nam":"nữ";
            Console.WriteLine("Bạn là {0}", gioitinh);
            ~Person.NV1;
        }
    }
}
