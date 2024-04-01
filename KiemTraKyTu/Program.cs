internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap mot ky tu bat ky");
        char kyTuNhap = Console.ReadKey().KeyChar;
        Console.WriteLine();
       
        if (char.IsLetter(kyTuNhap))
        {
            switch (char.ToLower(kyTuNhap))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"Ky tu {kyTuNhap} la nguyen am.");
                    break;
            }
        }
        else if (char.IsDigit(kyTuNhap))
        {
            Console.WriteLine($"Ky tu {kyTuNhap} la chu so.");
        }
        else
        {
            Console.WriteLine($"Ky tu {kyTuNhap} là ky tu khac");
        }
        Console.ReadLine();
    }
}