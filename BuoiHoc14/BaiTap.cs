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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Xin mời nhập tên: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("Xin mời nhập ngày sinh: ");
            NgaySinh = Console.ReadLine();
            Console.WriteLine("Xin mời nhập giới tính: ");
            GioiTinh = Console.ReadLine();
            Console.WriteLine("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine("Sinh viên {0} có các thông tin sau: ", HoTen);
            Console.WriteLine("Ngày sinh: {0}", NgaySinh);
            Console.WriteLine("Giới tính: {0}", GioiTinh);
            Console.WriteLine("Địa chỉ: {0}", DiaChi);
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
            Id = Console.ReadLine();
            if (Id.Length > 9)
            {
                Console.WriteLine("Xin mời nhập lại(ID bao gồm 8 chữ số)");
                goto nhapid;
            }
        nhapdtb:
            Console.WriteLine("Nhập điểm trung bình của bạn: ");
            PointAverage = Console.ReadLine();
            int Int_PointAverage = int.Parse(PointAverage);
            if (Int_PointAverage < 0 || Int_PointAverage > 10)
            {
                Console.WriteLine("Xin mời nhập lại điểm trong khoảng 0-10");
                goto nhapdtb;
            }
        nhapemail:
            Console.WriteLine("Nhập email của bạn: ");
            Email = Console.ReadLine();
            if (!Email.Contains('@'))
            {
                Console.WriteLine("Xin mời nhập lại đúng định dạng email");
                goto nhapemail;
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("ID:  {0}", Id);
            Console.WriteLine("Điểm: {0}", PointAverage);
            Console.WriteLine("Email: {0}", Email);
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
    public class Teacher : Person
    {
        private string classRoom;
        private string salaryPerHour;
        private string workHour;

        public string ClassRoom { get => classRoom; set => classRoom = value; }
        public string SalaryPerHour { get => salaryPerHour; set => salaryPerHour = value; }
        public string WorkHour { get => workHour; set => workHour = value; }

        public override void PutInfo()
        {
            base.PutInfo();
            char[] nameClass = { 'G', 'H', 'I', 'K', 'L', 'M' };
            nhaplailophoc:
            Console.WriteLine("Nhập tên lớp học: ");
            ClassRoom = Console.ReadLine();
            if (!nameClass.Contains(ClassRoom[0]))
            {
                goto nhaplailophoc;
            }
            Console.WriteLine("Nhập mức lương mỗi giờ dạy: ");
            SalaryPerHour = Console.ReadLine();
            Console.WriteLine("Nhập số giờ dạy trong tuần: ");
            WorkHour = Console.ReadLine();
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Lớp dạy:  {0}", ClassRoom);
            Console.WriteLine("Mức lương: {0}", SalaryPerHour);
            Console.WriteLine("Số giờ đã dạy: {0}", WorkHour);
        }

        public int TinhLuong()
        {
            if (ClassRoom[0] == 'G'|| ClassRoom[0] == 'H' || ClassRoom[0] == 'I' || ClassRoom[0] == 'K')
            {
                return int.Parse(SalaryPerHour)*int.Parse(WorkHour);
            }
            else
            {
                return int.Parse(SalaryPerHour)*int.Parse(WorkHour) + 200000;
            }
        }
    }
}
