using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBAcademy
{
    public class BuoiHoc10
    {
        public static void TaoDanhSachLop()
        {
            Dictionary<string, string> ten_Ho = new Dictionary<string, string>();
            Dictionary<string, string> ten_TenDem = new Dictionary<string, string>();
        nhaplai:
            Console.WriteLine("Nhập tên các thành viên trong lớp(ấn 'end' để kết thúc): ");
            string tenThanhVien = Console.ReadLine();
            Console.Clear();

            if (tenThanhVien != "end")
            {
                goto nhaplai;
            }
            else
            {
                tenThanhVien = null;
                Console.WriteLine("Danh sách lớp sau khi đã sắp xếp: ");
                ThemTenVaoDanhSach(tenThanhVien,ref ten_Ho,ref ten_TenDem);
            }
        }
        public static void ThemTenVaoDanhSach(string hoVaTen,ref Dictionary<string,string> firstAndLastname,ref Dictionary<string,string> firstAndMiddlename)
        {
            string[] array_tenThanhVien = hoVaTen.Split(' ');

            firstAndLastname.Add(array_tenThanhVien[0], array_tenThanhVien[array_tenThanhVien.Length-1]);
            if (array_tenThanhVien.Length == 2)
            {
                firstAndMiddlename.Add(array_tenThanhVien[0],null);
            } else
            {
                for (int i = 1; i < array_tenThanhVien.Length - 1; i++)
                {
                    firstAndMiddlename.Add(array_tenThanhVien[0], array_tenThanhVien[1] += array_tenThanhVien[i]);
                }
            }
            foreach (var item in firstAndLastname)
            {
                Console.WriteLine(item.Key + item.Value);
            }
        }
    }
}
