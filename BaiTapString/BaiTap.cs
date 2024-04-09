using System.Text;

namespace BaiTapString
{
    internal class BaiTap
    {
        public static void NhapChuoi()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập một chuỗi bất kỳ: ");
            string chuoiNhapVao = Console.ReadLine();

            KiemTraKyTuChuoi(chuoiNhapVao);

            static void KiemTraKyTuChuoi(string stringArray)
            {
                string chuoiSo = "0123456789";
                string chuoiChuThuong = "abcdefghiklmnopqrstuvwxyz";
                string chuoiChuHoa = chuoiChuThuong.ToUpper();
                foreach (var item in stringArray)
                {
                    bool kiemTra = chuoiSo.Contains(item);
                    if (kiemTra)
                    {
                        Console.WriteLine($"Chuỗi có chứa ký tự số");
                        break;
                    }
                }       
            }
        }
    }
}
