using System.Text;
using System.Xml.Linq;

namespace BuoiHoc11
{   
    internal class Program
    {   //Bài 1: Tạo danh sách lớp và sắp xếp theo các phương pháp sắp xếp đã học
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> danhSachLop = new List<string>();
        nhaplai:
            Console.WriteLine("Nhập tên các thành viên trong lớp(ấn 'end' để kết thúc): ");
            string tenThanhVien = Console.ReadLine();
            Console.Clear();
            if (tenThanhVien != "end")
            {
                danhSachLop.Add(tenThanhVien);
                goto nhaplai;
            }
            else
            {
                Console.WriteLine("Danh sách lớp sau khi đã sắp xếp: ");
                string[] aray_danhSachLop = danhSachLop.ToArray(); 
                SapXepChen(aray_danhSachLop);
            }
        }
        public static void SapXepChen(string[] name)
            {

            for (int i = 0; i < name.Length - 1; i++)
            {
                string boNhoTen = name[i];
                int viTri = i - 1;
                string[] array_boNhoTen = boNhoTen.Split(" ");

                while (viTri >= 0)
                {
                    string[] array_name = name[viTri].Split(" ");
                    if (array_name[array_name.Length-1].CompareTo(array_boNhoTen[array_boNhoTen.Length - 1])>0 || array_name[array_name.Length - 1].CompareTo(array_boNhoTen[array_boNhoTen.Length - 1]) == 0 && array_name[array_name.Length - 2].CompareTo(array_boNhoTen[array_boNhoTen.Length - 2]) > 0)
                    {
                        name[viTri + 1] = name[viTri];
                        viTri--;
                    }
                    else
                    {
                        break;
                    }          
                }
                name[viTri + 1] = boNhoTen;
            }
        }
    }
}
