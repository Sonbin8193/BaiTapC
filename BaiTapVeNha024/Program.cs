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
        public static void TimUocSoNguyenTo()
        {
            Console.WriteLine();
        }
    }
}
