using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc10
{
    //Tìm các giá trị lớn nhất, nhỏ nhất và giá trị trung bình
    public class BaiTap1
    {
        public static void TaoMang()
        {
            Random random = new Random();
            int[] mangSo = new int[2000];
            for (int i = 0; i < 1999; i++)
            {
                mangSo[i] = random.Next(0, 501);
            }
            TimViTri(TimMax(mangSo),mangSo);
            TimViTri(TimMin(mangSo), mangSo);
            TimViTri(TimGiaTriTrungBinh(mangSo),mangSo);
        }
        static int TimMax(int[] array)
        {
            int max = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
        static int TimMin(int[] array)
        {
            int min = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] < min) { min = array[i]; }
            }
            return min;
        }
        static int TimGiaTriTrungBinh(int[] array)
        {
            int tong = 0;
            int trungBinh = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                tong += array[i];
            }
            trungBinh = tong/array.Length;
            return trungBinh;
        }
        static void TimViTri(int giaTri, int[] array)
        {
            string viTri = "";
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == giaTri) 
                {
                    viTri += $"{i},";
                }
            }
            Console.WriteLine(viTri);
        }
    }
    // Cho 1 mảng có 100 số nguyên từ 1000 đến 5001, tìm số xuất hiện ít nhất & nhiều nhất
    // Viết 1 hàm tên gồm họ và tên. Viết hàm sắp xếp theo bảng chữ cái
    public class BaiTap2()
    {
        public static void TaoDanhSachLop()
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
                ThemDuLieu(danhSachLop);
            }
        }
        static void ThemDuLieu(List<string> nameList)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<string> names = nameList;
            names.Sort((name1, name2) => {
                var array1 = name1.Split(" ");
                var array2 = name2.Split(" ");
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
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}


