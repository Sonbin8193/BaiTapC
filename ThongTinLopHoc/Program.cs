﻿using System.Data;

namespace ThongTinLopHoc
{
    internal class Program
    {
        public struct HocVien
        {
            public string HoTen;
            public int NgaySinh;
            public string Gender;
            public string Address;
            public string NgonNguLapTrinh;
            public void DisplayInfo()
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Thong tin cua hoc vien {HoTen}");
                Console.WriteLine($"Gioi tinh: {Gender}");
                Console.WriteLine($"NgaySinh: {NgaySinh}");
                Console.WriteLine($"Dia Chi: {Address}");
                Console.WriteLine($"NgonNguLapTrinh: {NgonNguLapTrinh}");
            }
        }
        public static void Main()
        {

            HocVien PhamNguyenMinhPhuc = new HocVien();
            PhamNguyenMinhPhuc.HoTen = "Pham Nguyen Minh Phuc";
            PhamNguyenMinhPhuc.Gender = "Nam";
            PhamNguyenMinhPhuc.NgaySinh = 30041999;
            PhamNguyenMinhPhuc.Address = "Ho Chi Minh";
            PhamNguyenMinhPhuc.NgonNguLapTrinh = "C#";

            HocVien PhiDucAnh = new HocVien();
            PhiDucAnh.HoTen = "Phi Duc Anh";
            PhiDucAnh.Gender = "Nam";
            PhiDucAnh.NgaySinh = 20011997;
            PhiDucAnh.Address = "Bac Ninh";
            PhiDucAnh.NgonNguLapTrinh = "C#";

            HocVien NghiemMinhToan = new HocVien();
            NghiemMinhToan.HoTen = "Nghiem Minh Toan";
            NghiemMinhToan.Gender = "Nam";
            NghiemMinhToan.NgaySinh = 08032001;
            NghiemMinhToan.Address = "Ha Noi";
            NghiemMinhToan.NgonNguLapTrinh = "C#";

            HocVien CaoVietHoang = new HocVien();
            CaoVietHoang.HoTen = "Cao Viet Hoang";
            CaoVietHoang.Gender = "Nam";
            CaoVietHoang.NgaySinh = 02052000;
            CaoVietHoang.Address = "Thanh Hoa";
            CaoVietHoang.NgonNguLapTrinh = "C#";

            HocVien LeTrungKien = new HocVien();
            LeTrungKien.HoTen = "Le Trung Kien";
            LeTrungKien.Gender = "Nam";
            LeTrungKien.NgaySinh = 29111997;
            LeTrungKien.Address = "Ha Noi";
            LeTrungKien.NgonNguLapTrinh = "C#";

            HocVien NguyenVanTuan = new HocVien();
            NguyenVanTuan.HoTen = "Nguyen Van Tuan";
            NguyenVanTuan.Gender = "Nam";
            NguyenVanTuan.NgaySinh = 13122002;
            NguyenVanTuan.Address = "Quang Ninh";
            NguyenVanTuan.NgonNguLapTrinh = "C#";

            HocVien VuPhungHoang = new HocVien();
            VuPhungHoang.HoTen = "Vu Phung Hoang";
            VuPhungHoang.Gender = "Nam";
            VuPhungHoang.NgaySinh = 18081994;
            VuPhungHoang.Address = "Nam Dinh";
            VuPhungHoang.NgonNguLapTrinh = "C#";

            HocVien NguyenThienLoc = new HocVien();
            NguyenThienLoc.HoTen = "Nguyen Thien Loc";
            NguyenThienLoc.Gender = "Nam";
            NguyenThienLoc.NgaySinh = 03122002;
            NguyenThienLoc.Address = "Thai Binh";
            NguyenThienLoc.NgonNguLapTrinh = "C#";

            HocVien LeTruongTri = new HocVien();
            LeTruongTri.HoTen = "Le Truong Tri";
            LeTruongTri.Gender = "Nam";
            LeTruongTri.NgaySinh = 23112004;
            LeTruongTri.Address = "Long An";
            LeTruongTri.NgonNguLapTrinh = "C#";

            HocVien VuTrungHieu = new HocVien();
            VuTrungHieu.HoTen = "Vu Trung Hieu";
            VuTrungHieu.Gender = "Nam";
            VuTrungHieu.NgaySinh = 28022001;
            VuTrungHieu.Address = "Ha Noi";
            VuTrungHieu.NgonNguLapTrinh = "C#";

            HocVien TranChiHao = new HocVien();
            TranChiHao.HoTen = "Tran Chi Hao";
            TranChiHao.Gender = "Nam";
            TranChiHao.NgaySinh = 17012003;
            TranChiHao.Address = "Ha Noi";
            TranChiHao.NgonNguLapTrinh = "C#";

            HocVien TrinhBuiHoangAnh = new HocVien();
            TrinhBuiHoangAnh.HoTen = "Trinh Bui Hoang Anh";
            TrinhBuiHoangAnh.Gender = "Nam";
            TrinhBuiHoangAnh.NgaySinh = 02062000;
            TrinhBuiHoangAnh.Address = "Hai Phong";
            TrinhBuiHoangAnh.NgonNguLapTrinh = "C#";
            

            Console.WriteLine("Ten Hoc Vien: ");
            VuPhungHoang.HoTen = Console.ReadLine();
            Console.WriteLine("Ngay Sinh: ");
            VuPhungHoang.NgaySinh = int.Parse(Console.ReadLine());
            Console.WriteLine("GioiTinh: ");
            VuPhungHoang.Gender = Console.ReadLine();
            Console.WriteLine("Dia Chi: ");
            VuPhungHoang.Address = Console.ReadLine();
            Console.WriteLine("NgonNguLapTrinh: ");
            VuPhungHoang.NgonNguLapTrinh = Console.ReadLine();
            VuPhungHoang.DisplayInfo();
            PhamNguyenMinhPhuc.DisplayInfo();
            PhiDucAnh.DisplayInfo();
            NghiemMinhToan.DisplayInfo();
            CaoVietHoang.DisplayInfo();
            LeTruongTri.DisplayInfo();
            LeTrungKien.DisplayInfo();
            NguyenThienLoc.DisplayInfo();
            NguyenVanTuan.DisplayInfo();
            PhamNguyenMinhPhuc.DisplayInfo();
            VuTrungHieu.DisplayInfo();
            TrinhBuiHoangAnh.DisplayInfo();
            Console.ReadLine();
        }
        
    }
}
