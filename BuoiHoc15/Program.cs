using System.Text;

namespace BuoiHoc15
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.OutputEncoding = Encoding.UTF8;
           Cat meoDen = new Cat
            {
                Name = "Mèo đen",
                Age = 10,
                Food = "Cá khô"
            };
            Dog choTrang = new Dog
            {
                Name = "Phốc",
                Age = 10,
                Food = "Cơm"
            };
            People person = new People
            {
                Name = "Sơn",
                Old = 29,
                Address = "Hà Nội",
                MobilePhone = "0962932193"
            };
            MyCar toyota = new MyCar
            {
                Name = "Huyndai",
                Color = "Xanh",
                Old = 6
            };
            meoDen.Run();
        }
    }
}
