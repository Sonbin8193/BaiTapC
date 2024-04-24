using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc14
{
    internal class People
    {
        private string name;
        private string birthday;
        private int address;

        public string Name { get => name; set => name = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public int Address { get => address; set => address = value; }
        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Birthday: {0}", birthday);
            Console.WriteLine("Address: {0}", address);
        }

        public virtual void ShowInfo2()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Birthday: {0}", birthday);
            Console.WriteLine("Address: {0}", address);
        }
    }
    internal class Worker : People
    {
        private int salary;

        public int Salary { get => salary; set => salary = value; }

        public new void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Salary: {0}", salary);
        }

        override public void ShowInfo2()
        {
            base.ShowInfo();
            Console.WriteLine("Salary: {0}", salary);
        }
    }

    public class Person()
    {
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public virtual void PutInfo()
        {
            Console.WriteLine("Xin mời nhập tên của bạn: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Xin mời nhập ngày sinh của bạn: ");
            NgaySinh = Console.ReadLine();
            Console.WriteLine("Xin mời nhập giới tính của bạn: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ của bạn: ");
            DiaChi = Console.ReadLine();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Tên của bạn là {0}", HoTen);
            Console.WriteLine("Ngày sinh của bạn là {0}", NgaySinh);
            Console.WriteLine("Giới tính của bạn là {0}", GioiTinh);
            Console.WriteLine("Địa chỉ của bạn là {0}", DiaChi);
        }
    }
    public class Student : Person
    {
        private string id;
        private string pointAverage;
        private string email;

        public string Id { get => id; set => id = value; }
        public string PointAverage { get => pointAverage; set => pointAverage = value; }
        public string Email { get => email; set => email = value; }
        public override void PutInfo()
        {
            base.PutInfo();
        nhapid:
            Console.WriteLine("Nhập ID của bạn: ");
            //Console.Clear();
            Id = Console.ReadLine();
            if (Id.Length > 9)
            {
                Console.WriteLine("Xin mời nhập lại");
                goto nhapid;
            }
        nhapdtb:
            Console.WriteLine("Nhập điểm trung bình của bạn: ");
            //Console.Clear();
            PointAverage = Console.ReadLine();
            int Int_PointAverage = int.Parse(PointAverage);
            if (Int_PointAverage < 0 || Int_PointAverage > 10)
            {
                Console.WriteLine("Xin mời nhập lại");
                goto nhapdtb;
            }
        nhapemail:
            Console.WriteLine("Nhập email của bạn: ");
            //Console.Clear();
            Email = Console.ReadLine();
            if (!Email.Contains('@'))
            {
                Console.WriteLine("Xin mời nhập lại");
                goto nhapemail;
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ID của bạn là {0}", Id);
            Console.WriteLine("Điểm của bạn là {0}", PointAverage);
            Console.WriteLine("Email của bạn là {0}", Email);
        }
        public bool XetHocBong(int point)
        {
            bool result = false;
            if (point>8)
            {
                Console.WriteLine("Đủ điều kiện nhận học bổng");
                result = true;
            }
            else
            {
                Console.WriteLine("Không đủ điều kiện nhận học bổng"); ;
            }
            return result;
        }
    }
}
