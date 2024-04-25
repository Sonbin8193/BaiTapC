using System;
using System.Collections.Generic;
using System.Linq;
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
                    NhapDuLieuSinhVien(N, students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;;
                case "2":
                    HienThiDuLieuSinhVien(students);
                    Console.ReadLine();
                    Console.Clear();
                    goto chontiep;
                case "3":
                    TimDiemCaoNhatVaThapNhat(students);
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

            static void NhapDuLieuSinhVien(int n, List<Student> _students)
            {
                for (int i = 0; i < n; i++)
                {
                    _students.Add(new Student());
                    _students[i].PutInfo();
                }
            }

            static void HienThiDuLieuSinhVien(List<Student> _student)
            {
                foreach (var item in _student)
                {
                    item.ShowInfo();
                }
            }

            static void TimDiemCaoNhatVaThapNhat(List<Student> _student)
            {
                List<Student> studentList = _student;
                studentList.Sort((name1, name2) => { return int.Parse(name1.PointAverage).CompareTo(int.Parse(name2.PointAverage)); });
                Console.WriteLine($"Điểm cao nhất là {studentList[studentList.Count - 1].PointAverage} thuộc về sinh viên {studentList[studentList.Count - 1].HoTen}");
                Console.WriteLine($"Điểm thấp nhất là {studentList[0].PointAverage} thuộc về sinh viên {studentList[0].HoTen}");
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
                    if (_student[i].XetHocBong(int.Parse(_student[i].PointAverage)))
                    {
                        namesList.Add(_student[i]);
                    }
                }
                namesList.Sort((name1, name2) => { return name1.PointAverage.CompareTo(name2.PointAverage); });
                foreach (var name in namesList)
                {
                    name.ShowInfo();
                }
            }
        }
    }
    internal class TeacherTest
    {
        static void Main(string[] args)
        {

        }
    }
}
