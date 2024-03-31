namespace NhapHaiChuSo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so thu 1: ");
            int soMot = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao so thu 2: ");
            soMot = soMot + int.Parse(Console.ReadLine());
            Console.WriteLine($"Ket qua cua phep tinh cong la = {soMot}");
            Console.ReadLine();
        }
    }
}
