namespace BaiTapStruct
{
        struct NhanVien
        {
            public string soNguoiDiLam;
        }
        struct ChamCong
        {
            public string ngayDiLam;
            public NhanVien nguoiDiLam;
        }
    internal class Program
    {
        static void Main()
        {
            ChamCong chamCongThu2;
            chamCongThu2.ngayDiLam = "thu 2";
            ChamCong chamCongThu3;
            chamCongThu3.ngayDiLam = "thu 3";
            chamCongThu2.nguoiDiLam.soNguoiDiLam = "5 nguoi";
            chamCongThu3.nguoiDiLam.soNguoiDiLam = "7 nguoi";
            Console.WriteLine($"Ngay {chamCongThu2.ngayDiLam} có {chamCongThu2.nguoiDiLam.soNguoiDiLam} di lam");
            Console.WriteLine($"Ngay {chamCongThu3.ngayDiLam} có {chamCongThu3.nguoiDiLam.soNguoiDiLam} di lam");

        }
    }
    // Khai bao mot struct co phuong thuc va mot truong private

    struct ViTriTuyenDung
    {
        public string chucVu;
        private int mucLuong;
    }
}
