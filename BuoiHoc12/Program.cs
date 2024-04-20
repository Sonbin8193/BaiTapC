using System.Text;

namespace BuoiHoc12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //SinhVien SV1 = new SinhVien();
            //SV1._name = "Phạm Giang Sơn";
            //SV1._diemToan = SV1.NhapDiem();
            //SV1._diemHoa = SV1.NhapDiem();
            //SV1._diemLy = SV1.NhapDiem();
            //Console.WriteLine($"Sinh Viên {SV1._name} có điểm Toán = {SV1._diemToan}, điểm Lý = {SV1._diemLy}, điểm Hóa = {SV1._diemHoa}");
            //Console.WriteLine($"Xếp loại học lực {SV1.XetHocLuc(SV1.DiemTrungBinh(out int diemTongKet))}");

            Point diemA = new Point();
            diemA.NhapToaDo(2, 11, 9);
            Point diemB = new Point();
            diemB.NhapToaDo(15, 12, 3);
            Console.WriteLine(diemA.TinhTheTich(0, diemA._toaDoX, diemA._toaDoY, diemA._toaDoZ));
            Console.WriteLine(diemA.TinhTheTich(Point.TinhKhoangCach(diemA._toaDoX,0,diemA._toaDoY,0,diemA._toaDoZ,0),diemA._toaDoX, diemA._toaDoY, diemA._toaDoZ));
            Console.WriteLine($"Khoảng cách giữa 2 điểm A và B là: {Point.TinhKhoangCach(diemA._toaDoX, diemB._toaDoX, diemA._toaDoY, diemB._toaDoY, diemA._toaDoZ, diemB._toaDoZ)}");
            Console.WriteLine();
        }
    }
}
