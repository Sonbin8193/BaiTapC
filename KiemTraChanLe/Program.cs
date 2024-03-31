namespace KiemTraChanLe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao mot so bat ky: ");
            int soNhap = int.Parse(Console.ReadLine());
            if (soNhap % 2 == 0)
            {
                Console.WriteLine("So da nhap la so chan");
            }else
            {
                Console.WriteLine("So da nhap la so le");
            }
        }
    }
}
