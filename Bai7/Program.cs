namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập một ký tự: ");
            char kyTu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine($"Mã Unicode của ký tự '{kyTu}' là {(int)kyTu}");
            Console.Write("Nhập mã Unicode từ 0 đến 255: ");
            int maUnicode = int.Parse(Console.ReadLine());
            if (maUnicode <256 && maUnicode >-1)
            {
                char kyTuUnicode = (char)maUnicode;
                Console.WriteLine($"Ký tự của mã Unicode {maUnicode} là '{kyTuUnicode}'");
            }
            else
            {
                Console.WriteLine("Mã Unicode không hợp lệ.");
            }
            Console.WriteLine() ;
            Console.ReadLine(); 
        }
    }
}
