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
}

