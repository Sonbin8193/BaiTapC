using System;

namespace BaiTapVeNha024
{
    public class Bai1
    {
        public static void TimThuaSoNguyenTo()
        {
            Console.WriteLine("Nhap vao mot so bat ky");
            int soChia = int.Parse(Console.ReadLine());
            int soBiChia = 2;
            Console.WriteLine($"Tap hop thua so nguyen to cua {soChia} là: "); ;
            string ketQua = "";
            while (soBiChia <= soChia)
            {
                if (soChia % soBiChia == 0)
                {
                    ketQua += $" {soBiChia}";
                    soChia /= soBiChia;
                    soBiChia = 2;
                }
                else
                {
                    soBiChia++;
                }
            }
            Console.WriteLine(ketQua);
            Console.ReadLine();
        }
    }

    public class Bai2
    {
        public static void TimUocSo()
        {
            Console.WriteLine("Nhap vao mot so bat ky: ");
            int soChia = int.Parse(Console.ReadLine());
            int soBiChia = 1;
            Console.WriteLine($"Tap hop uoc so cua {soChia} là: "); ;
            string ketQua = "";
            while (soBiChia <= soChia)
            {
                if (soChia % soBiChia == 0)
                {
                    ketQua += $" {soBiChia}";
                }
                soBiChia++;
            }
            Console.WriteLine(ketQua);
            Console.ReadLine();
        }
    }
    public class Bai3
    {
        public static void TimUocSoChungVaBoiSoChung()
        {
            Console.Write("Nhap so dau tien: ");
            int soDau = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int soThuHai = int.Parse(Console.ReadLine());
            int boiSoChungNhoNhat;
            int uocSoChungLonNhat = 1;
            int soLon = (soDau > soThuHai) ? soDau : soThuHai;
            int soBe = (soDau < soThuHai) ? soDau : soThuHai;

            while (uocSoChungLonNhat != 0)
            {
                uocSoChungLonNhat = soLon % soBe;
                if (uocSoChungLonNhat == 0)
                {
                    uocSoChungLonNhat = soBe;
                    break;
                }
                else
                {
                    soLon = soBe;
                    soBe = uocSoChungLonNhat;
                }
            }
            Console.WriteLine($"Uoc so chung lon nhat la {uocSoChungLonNhat}");
            boiSoChungNhoNhat = soDau * soThuHai / uocSoChungLonNhat;
            Console.WriteLine($"Boi so chung nho nhat la {boiSoChungNhoNhat}");

        }
    }

    public class Ngay0504
    {
        public static void Bai1()
        {
            nhaplai:
            Console.WriteLine("Nhap vao ngay thang bat ky cua nam 2023 dang dd/mm/yyyy");
            string input = Console.ReadLine();

            string dateFormat = "dd/mm/yyyy";

            if (DateTime.TryParseExact(input, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime result))
            {
                Console.WriteLine($"Thu cua ngay {result:dd/mm/yyyy} la {result:dddd} ");
            }
            else
            {
                Console.WriteLine("Chuỗi không hợp lệ, vui lòng nhập lại");
                goto nhaplai;
            }
        }

        public static void Bai2()
        {
            nhapLaiSoNhiPhan:
            Console.WriteLine("Nhập vào một số nhị phân bất kỳ: ");
            string daySoNhiPhan = Console.ReadLine();
            foreach (var j in daySoNhiPhan)
            {
                if (j != '1' && j != '0')
                {
                    Console.WriteLine("Số đã nhập không phải dạng nhị phân, vui lòng nhập lại: ");
                    goto nhapLaiSoNhiPhan;
                }
            }
            double daySoThapPhan=0;

            for (int i = 0; i < daySoNhiPhan.Length; i++)
            {
                if (daySoNhiPhan[daySoNhiPhan.Length-1-i]=='1')
                {
                    daySoThapPhan += Math.Pow(2,i) ;
                }
            }
            Console.WriteLine($"Giá trị của {daySoNhiPhan} là {daySoThapPhan}");
        }

        /* 
         * public static void Bai3()
        {
            Console.WriteLine("Nhập vào dãy số bất kỳ (nhỏ hơn 9 chữ số): ");
            string daySoBatKy = Console.ReadLine();
            string[] daySoBangSo = new string[9];
            string[] daySoBangChu = new string[9];
            string ketQua = "";
            for (int i = 0; i < daySoBatKy.Length; i++)
            {
                daySoBangSo[i] = daySoBatKy[daySoBatKy.Length-i-1];
            }
            for (int i = 0; i < daySoBangSo.Length-1; i++)
            {
                switch (daySoBangSo[i]) 
                {
                    case "0":
                        daySoBangChu[i] = "Không";
                        break;
                    case "1":
                        daySoBangChu[i] = "Một";
                        break;
                    case "2":
                        daySoBangChu[i] = "Hai";
                        break;
                    case "3":
                        daySoBangChu[i] = "Ba";
                        break;
                    case "4":
                        daySoBangChu[i] = "Bốn";
                        break;
                    case "5":
                        daySoBangChu[i] = "Năm";
                        break;
                    case "6":
                        daySoBangChu[i] = "Sáu";
                        break;
                    case "7":
                        daySoBangChu[i] = "Bảy";
                        break;
                    case "8":
                        daySoBangChu[i] = "Tám";
                        break;
                    case "9":
                        daySoBangChu[i] = "Chín";
                        break;                   
                }
                daySoBangChu[1] += "Mươi";
                daySoBangChu[2] += "Trăm";
                daySoBangChu[3] += "Nghìn";
                daySoBangChu[4] += "Mươi";
                daySoBangChu[5] += "Trăm";
                daySoBangChu[6] += "Triệu";
                daySoBangChu[7] += "Mươi";
                daySoBangChu[8] += "Trăm";
                for (int j = 0; j < daySoBangChu.Length - 1; j++)
                {
                    ketQua += daySoBangChu[daySoBangChu.Length - i-1];
                }
                Console.WriteLine(ketQua);
            }
        } */
    }
}

