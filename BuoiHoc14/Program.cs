using System.Linq;

namespace BuoiHoc14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Person person1 = new Student();
            //person1.PutInfo();
            //person1.ShowInfo();

            //Student student = new Student();
            //student.PutInfo();
            //student.ShowInfo();
            //int point = int.Parse(student.PointAverage);
            //student.XetHocBong(point);


            List<Student> students = new List<Student>();
            for (int i = 0; i < 5; i++)
            {
                students.Add(new Student());
                students[i].PutInfo();
            }
            foreach (var item in students)
            {
                item.ShowInfo();
            }
            int diemMax = 0;
            int diemMin = 0;
            for (int i = 0; i < 5; i++)
            {
                if (diemMax> int.Parse(students[i].PointAverage))
                {
                    diemMax = int.Parse(students[i].PointAverage);
                }
                if (diemMin < int.Parse(students[i].PointAverage))
                {
                    diemMin = int.Parse(students[i].PointAverage);
                }
            }
            static void TimSinhVien(Student[] a)
            {
                Console.WriteLine("Nhập mã sinh viên bạn muốn tìm: ");
                string maSV = Console.ReadLine();
                for (int i = 0; i < 5; i++)
                {
                    if (maSV.Contains(a[i].Id))
                    {
                        Console.WriteLine("Mã sinh viên {0} là của sinh viên {1}", a[i].Id, a[i].HoTen);
                    }
                }
            }
            static void XepDanhSach(Student[] a)
            {
                List<Student> namesList = new List<Student>();
                for (int i = 0; i < 5; i++)
                {
                    namesList.Add(a[i]);
                }
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
            static void XepDanhSachHocBong(Student[] a)
            {
                List<Student> namesList = new List<Student>();
                for (int i = 0; i < 5; i++)
                {
                    if (a[i].XetHocBong(int.Parse(a[i].PointAverage)))
                    {
                        namesList.Add(a[i]);
                    }
                }
                namesList.Sort((name1, name2) => { return name1.PointAverage.CompareTo(name2.PointAverage); });
                foreach (var item in namesList)
                {
                    item.ShowInfo();
                }
            }
        }
    }
}
