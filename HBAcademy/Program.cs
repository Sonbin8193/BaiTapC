namespace HBacademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HBAcademy");
            Bai2.Test1.Hello();
            Bai2.Bai2Child.Test2.Hello();
            Bai2.Bai2Child.Retangle.GanGiaTriHinhChuNhat(10,8);
        }
    }
}