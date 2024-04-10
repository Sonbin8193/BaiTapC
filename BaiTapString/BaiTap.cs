using System.Text;

namespace BaiTapString
{
    internal class BaiTap
    {
        public static void ChuoiString()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập một chuỗi bất kỳ: ");
            string chuoiNhapVao = Console.ReadLine();

            XoaDauCach(chuoiNhapVao);

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
                        Console.WriteLine("Chuỗi có chứa ký tự số");
                        break;
                    }
                }
                foreach (var item in stringArray)
                {
                    bool kiemTra2 = chuoiChuThuong.Contains(item);
                    if (kiemTra2)
                    {
                        Console.WriteLine("Chuỗi có chứa ký tự chữ thường");
                        break;
                    }
                }

                foreach (var item in stringArray)
                {
                    bool kiemTra3 = chuoiChuHoa.Contains(item);
                    if (kiemTra3)
                    {
                        Console.WriteLine("Chuỗi có chứa ký tự chữ hoa");
                        break;
                    }
                }

            }
            static void KiemTraKyTuNhapVao(string stringArray)
            {
                Console.WriteLine("Nhập vào một ký tự bất kỳ: ");
                string kyTuNhapVao = Console.ReadLine();
                bool kiemTra = stringArray.Contains(kyTuNhapVao);
                if (kiemTra)
                {
                    Console.WriteLine("Ký tự vừa nhập có nằm trong chuỗi");
                } else
                {
                    Console.WriteLine("Ký tự vừa nhập không nằm trong chuỗi");
                }
            }
            static void KiemTraChuoiNhapVao(string stringArray)
            {
                Console.WriteLine("Nhập vào một câu/ từ bất kỳ: ");
                string chuoiKiemTra = Console.ReadLine();
                bool kiemTra = stringArray.Contains(chuoiKiemTra);
                if (kiemTra)
                {
                    Console.WriteLine("Ký tự vừa nhập có nằm trong chuỗi");
                }
                else
                {
                    Console.WriteLine("Ký tự vừa nhập không nằm trong chuỗi");
                }
                int doDai = stringArray.Length - chuoiKiemTra.Length;
                if (doDai>0)
                {
                    Console.WriteLine("Chuỗi vừa nhập có độ dài ngắn hơn chuỗi gốc");
                }
                else if (doDai<0)
                {
                    Console.WriteLine("Chuỗi vừa nhập có độ dài dài hơn chuỗi gốc");
                }
                else
                {
                    Console.WriteLine("Hai chuỗi có độ dài bằng nhau");
                }
            }
            static void KiemTraTinhDoiXung(string stringArray)
            {
                for (int i = 0; i <= stringArray.Length/2; i++)
                {
                    if (stringArray[i] == stringArray[stringArray.Length-1-i])
                    {
                        if (i == stringArray.Length / 2 || i == (stringArray.Length - 1) / 2)
                        {
                            Console.WriteLine("Chuỗi vừa nhập là một chuỗi đối xứng");
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Chuỗi vừa nhập không phải là một chuỗi đối xứng");
                        break;
                    }
                }
            }
            static void KiemTraSoTu(string stringArray)
            {
                char dauCach = ' ';
                int count = 0;
                foreach (var item in stringArray)
                {
                    if (item == dauCach)
                    {
                        count += 1;
                    }
                }
                Console.WriteLine($"Chuỗi vừa nhập có tất cả {count} từ");
            }
            static void XoaDauCach(string stringArray)
            {
                string chuoiMoi = stringArray.Trim();
                // Xóa dấu cách cả chuỗi
                string chuoiMoiKhongDauCach = stringArray.Replace(" ", "");
                Console.WriteLine(chuoiMoiKhongDauCach);
            }
            static void DemKyTu(string stringArray)
            {
                string kyTuNhapVao = Console.ReadLine();
                bool ketQua = stringArray.Contains(kyTuNhapVao);
                int count = 0;
                foreach (var item in stringArray)
                {
                    if (ketQua)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Ký tự {kyTuNhapVao} xuất hiện {count} lần");
            }
        }
        public static void ChuoiStringBuilder()
        {
            StringBuilder chuoiSb = new StringBuilder("Xin chào");
            chuoiSb.Append("tất cả mọi người");
            chuoiSb.Clear();
            string format = "Xin chào, {0}! Hôm nay là ngày {1}.";
            string name = "Sơn";
            DateTime today = DateTime.Now.Date;
            chuoiSb.AppendFormat(format, name, today);
            chuoiSb.Insert(chuoiSb.Length / 2, "0000");
            chuoiSb.Remove((chuoiSb.Length / 2) -2, 4);
            chuoiSb.Replace("Xin chào", "Hello");
            chuoiSb.ToString();
            Console.WriteLine(chuoiSb);
        }
    }
}
