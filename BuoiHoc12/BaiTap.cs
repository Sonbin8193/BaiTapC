using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc12
{
    public class NhanVien
    {
        public string _name { get; set; }

        private string _date;

        public string Get_date()
        {
            return _date;
        }

        public void Set_date(string value)
        {
            DateOnly result;
            if (DateOnly.TryParse(value, out result))
            {
                _date = value;
            }
        }

        private string _country { get; set; }
        private double _salary { get; set; }
        private double _money { get; set; }

        public string ChuanHoaTen()
        {
            for (int i = 0; i < _name.Length-1; i++)
            {
                if (_name[i]==' ')
                {
                   
                }
            }
            return _name;
        }
    }
    //Bài 1: Tạo Class Sinh viên và nhập điểm, xuất ra học lực tương ứng
    public class SinhVien
    {
        public string _name { get; set; }
        public int _diemToan { get; set; }
        public int _diemHoa { get; set; }
        public int _diemLy { get; set; }

        public int NhapDiem()
        {
            Random random = new Random();
            int diem = random.Next(5, 11);
            return diem;
        }
        public int DiemTrungBinh(out int diemTongKet)
        {
            diemTongKet = (_diemHoa + _diemLy + _diemToan);
            return diemTongKet;
        }
        public string XetHocLuc(int diemTB)
        {
            string hocLuc="";
            if (diemTB>28)
            {
                hocLuc = "Xuất Sắc";
            } else if (26<diemTB && diemTB<29)
            {
                hocLuc = "Giỏi";
            } else if (23 < diemTB && diemTB < 27)
            {
                hocLuc = "Khá";
            } else if (19 < diemTB && diemTB < 24)
            {
                hocLuc = "Trung Bình";
            }
            else
            {
                hocLuc = "Kém";
            }
            return hocLuc;
        }
    }
    //Bài 2: Tạo lớp Point và mô tả theo yêu cầu
    public class  Point()
    {
        public int _toaDoX;
        public int _toaDoY;
        public int _toaDoZ;

        public void NhapToaDo(int x, int y, int z)
        {
            _toaDoX = x;
            _toaDoY = y;
            _toaDoZ = z;
        }
        public static double TinhKhoangCach(int a1, int a2, int b1, int b2, int c1, int c2)
        {
            return Math.Sqrt(Math.Pow(a1-a2,2) + Math.Pow(b1 - b2, 2) + Math.Pow(c1 - c2, 2));
        }

        public double TinhTheTich(double i,int a, int b, int c)
        {
            if (i>0)
            {
                return 4 / 3 * Math.PI * Math.Pow(i, 3);
            } else
            {
                return a * b * c;
            }
        }
    }
}
