namespace BuoiHoc13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HinhChuNhat a = new HinhChuNhat();
            //a.ChieuDai = 10;
            //a.ChieuRong = 20;
            //HinhChuNhat b = new HinhChuNhat();
            //b.ChieuDai = 15;
            //b.ChieuRong = 30;
            //HinhChuNhat c = new HinhChuNhat();
            //c = a + b;
            //Console.WriteLine(a.TinhDienTich());
            //Console.WriteLine(b.TinhDienTich());
            //Console.WriteLine(c.TinhDienTich());
            Person NV2 = new Person
            {
                Name1 = "Hùng",
                Birthday1 = "12052005",
                Salary1 = 125
            };
            Person NV1 = new Person("Sơn","12052005",125);
        }
    }
}
