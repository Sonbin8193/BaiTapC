using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc14
{
    internal class StudentTest
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Student> students = new List<Student>();
            chonlai:
            Console.WriteLine("Vui lòng chọn 1 trong các mục dưới đây: ");
            Console.WriteLine("1. Nhập thông tin cho sinh viên: ");
            chontiep:
            Console.WriteLine("2. Hiển thị thông tin các sinh viên đã nhập");
            Console.WriteLine("3. Hiển thị sinh viên có điểm trung bình cao nhất và thấp nhất");
            Console.WriteLine("4. Tìm kiếm sinh viên theo ID");
            Console.WriteLine("5. Sắp xếp lại tên sinh viên theo bảng chữ cái");
            Console.WriteLine("6. Hiển thị tên các sinh viên được nhận học bổng từ cao đến thấp");
            Console.WriteLine("Ấn \"0\" để thoát chương trình");
            string menuChon = Console.ReadLine();

            switch (menuChon){
                case "0":
                    Console.Clear();
                    Console.WriteLine("Kết thúc...");
                    Console.ReadLine();
                    break;
                case "1":
                    Console.WriteLine("Nhập số lượng sinh viên cần tạo: ");
                    int N = int.Parse(Console.ReadLine());
                    NhapDuLieu(N, students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                case "2":
                    HienThiDuLieu(students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                case "3":
                    TimCaoNhatVaThapNhat(students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                case "4":
                    TimSinhVien(students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                case "5":
                    XepDanhSach(students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                case "6":
                    XepDanhSachHocBong(students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                default:
                    Console.Clear();
                    Console.WriteLine("Xin mời chọn lại đúng số trong menu");
                    goto chonlai;
            }

            static void NhapDuLieu(int n, List<Student> _students)
            {
                for (int i = 0; i < n; i++)
                {
                    _students.Add(new Student());
                    _students[i].PutInfo();
                }
            }

            static void HienThiDuLieu(List<Student> _student)
            {
                foreach (var item in _student)
                {
                    item.ShowInfo();
                }
            }

            static void TimCaoNhatVaThapNhat(List<Student> _student)
            {
                List<Student> studentList = _student;
                studentList.Sort((name1, name2) => { return int.Parse(name1.HourWork).CompareTo(int.Parse(name2.HourWork)); });
                Console.WriteLine($"Điểm cao nhất là {studentList[studentList.Count - 1].HourWork} thuộc về sinh viên {studentList[studentList.Count - 1].HoTen}");
                Console.WriteLine($"Điểm thấp nhất là {studentList[0].HourWork} thuộc về sinh viên {studentList[0].HoTen}");
            }

            static void TimSinhVien(List<Student> _student)
            {
                Console.WriteLine("Nhập mã sinh viên bạn muốn tìm: ");
                string maSV = Console.ReadLine();
                for (int i = 0; i < 5; i++)
                {
                    if (maSV.Contains(_student[i].Id))
                    {
                        Console.WriteLine($"Mã sinh viên {_student[i].Id} là của sinh viên {_student[i].HoTen}");
                    }
                }
            }

            static void XepDanhSach(List<Student> _student)
            {
                List<Student> namesList = _student;
                namesList.Sort((name1, name2) => {
                    var array1 = name1.HoTen.Split(" ");
                    var array2 = name2.HoTen.Split(" ");
                    if (array1[array1.Length - 1] == array2[array2.Length - 1])
                    {
                        if (array1[array1.Length - 2] == array2[array2.Length - 2])
                        {
                            return array1[0].CompareTo(array2[0]);
                        }
                        else
                        {
                            return array1[array1.Length - 2].CompareTo(array2[array2.Length - 2]);
                        }
                    }
                    else
                    {
                        return array1[array1.Length - 1].CompareTo(array2[array2.Length - 1]);
                    }
                });
                foreach (var name in namesList)
                {
                    name.ShowInfo();
                }
            }

            static void XepDanhSachHocBong(List<Student> _student)
            {
                List<Student> namesList = _student;
                for (int i = 0; i < namesList.Count; i++)
                {
                    if (_student[i].XetHocBong(int.Parse(_student[i].HourWork)))
                    {
                        namesList.Add(_student[i]);
                    }
                }
                namesList.Sort((name1, name2) => { return name1.HourWork.CompareTo(name2.HourWork); });
                foreach (var name in namesList)
                {
                    name.ShowInfo();
                }
            }
        }
    }
    internal class TeacherTest : StudentTest
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Teacher> teachers = new List<Teacher>();
        chonlai1:
            Console.WriteLine("Vui lòng chọn 1 trong các mục dưới đây: ");
            Console.WriteLine("1. Nhập thông tin cho giáo viên: ");
        chontiep1:
            Console.WriteLine("2. Hiển thị thông tin các giáo viênn đã nhập");
            Console.WriteLine("3. Hiển thị giáo viên có giờ dạy trong tháng cao nhất");
            Console.WriteLine("4. Hiển thị giáo viên có lương nhận cao nhất");
            Console.WriteLine("Ấn \"0\" để thoát chương trình");
            string menuChon = Console.ReadLine();
            switch (menuChon)
            {
                case "0":
                    Console.Clear();
                    Console.WriteLine("Kết thúc...");
                    Console.ReadLine();
                    break;
                case "1":
                    Console.WriteLine("Nhập số lượng giáo viên: ");
                    int N = int.Parse(Console.ReadLine());
                    NhapDuLieu(N, teachers);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep1;
                case "2":
                    HienThiDuLieu(teachers);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep1;
                case "3":
                    TimCaoNhatVaThapNhat(teachers);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep1;
                case "4":
                    TimCaoNhatVaThapNhat(teachers,0);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep1;
                default:
                    Console.Clear();
                    Console.WriteLine("Xin mời chọn lại đúng số trong menu");
                    goto chonlai1;
            }
        }
        new static void NhapDuLieu(int n, List<Teacher> _teachers)
        {
            for (int i = 0; i < n; i++)
            {
                _teachers.Add(new Student());
                _teachers[i].PutInfo();
            }
        }
        new static void HienThiDuLieu(List<Teacher> _teachers)
        {
            foreach (var item in _teachers)
            {
                item.ShowInfo();
            }
        }
        new static void TimCaoNhatVaThapNhat(List<Teacher> _teachers)
        {
            List<Teacher> teacherList = _teachers;
            teacherList.Sort((name1, name2) => { return int.Parse(name1.WorkHour).CompareTo(int.Parse(name2.WorkHour)); });
            for (int i = 0; i < teacherList.Count; i++)
            {
                if (teacherList[teacherList.Count - 1].WorkHour == teacherList[i].WorkHour)
                {
                    Console.WriteLine($"Số giờ dạy cao nhất trong tuần là {teacherList[i].WorkHour} thuộc về giáo viên {teacherList[i].HoTen}");
                }
            }
        }
        new static void TimCaoNhatVaThapNhat(List<Teacher> _teachers, int n)
        {
            List<Teacher> teacherList = _teachers;
            for (int i = 0; i < teacherList.Count; i++)
            {
                if (teacherList[teacherList.Count - 1].TinhLuong() == teacherList[i].TinhLuong())
                {
                    Console.WriteLine($"Số giờ dạy cao nhất trong tuần là {teacherList[i].TinhLuong()} thuộc về giáo viên {teacherList[i].TinhLuong()}");
                }
            }
        }
    }
}
