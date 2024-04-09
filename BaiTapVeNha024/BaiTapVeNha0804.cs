using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BaiTapVeNha024
{
    public class BaiTapVeNha0804
    {      
        // In bảng sudoku
        public static void TaoDataBang()
        {
            int[,] bangSudoku = new int[9,9];
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    bangSudoku[i,j] = random.Next(1, 10);
                }
            }
            InDataBang(bangSudoku);
        }

        //In bảng ma phương lẻ
        public static void TaoDataMaPhuong()
        {
            Console.WriteLine("Nhập vào số A để in ra bảng AxA (số lẻ): ");
            int soHangCot = int.Parse(Console.ReadLine());
            double TONG = 0.5 * (Math.Pow(soHangCot, 2) + 1);      
            int[,] bangSo = new int[soHangCot + (soHangCot - 1), soHangCot + (soHangCot - 1)];
            int soDem = 0;
            for (int count = 0; count < soHangCot; count++)
            {
                int j = soHangCot-1;
                for (int i = 0; i < soHangCot; i++)
                {
                    bangSo[i + count, j + count] = ++soDem;
                    j--;
                }
            }
            for (int i = 0; i < bangSo.GetLength(0); i++)
            {
                for (int j = 0; j < bangSo.GetLength(1); j++)
                {
                    if (bangSo[i,j]==0)
                    {
                        continue;
                    }
                    if (i < (soHangCot-1)/2)
                    {
                        bangSo[i+soHangCot,j] = bangSo[i, j];
                        bangSo[i,j] = 0;
                    }
                    if (i > soHangCot-1 +(soHangCot - 1) / 2)
                    {
                        bangSo[i - soHangCot, j] = bangSo[i, j];
                        bangSo[i, j] = 0;
                    }
                    if (j < (soHangCot - 1) / 2)
                    {
                        bangSo[i, j + soHangCot] = bangSo[i, j];
                        bangSo[i, j] = 0;
                    }
                    if (j > soHangCot - 1 + (soHangCot - 1) / 2)
                    {
                        bangSo[i, j-soHangCot] = bangSo[i, j];
                        bangSo[i, j] = 0;
                    }
                }
            }
            InDataBang(TaoDataMaPhuongRutGon(bangSo));
        }
        //Tạo bảng Ma Phương
        public static int[,] TaoDataMaPhuongRutGon(int[,] array)
        {
            int[,] bangMaPhuongRutGon = new int[array.GetLength(0) - (array.GetLength(0) - 1)/2, array.GetLength(1) - (array.GetLength(1) - 1) / 2];
            for (int i = 0; i < bangMaPhuongRutGon.GetLength(0); i++)
            {
                for (int j = 0; j < bangMaPhuongRutGon.GetLength(1); j++)
                {
                    bangMaPhuongRutGon[i,j] = array[i+ (bangMaPhuongRutGon.GetLength(0) - 1) / 2, j + (bangMaPhuongRutGon.GetLength(1) - 1) / 2];
                }
            }
            return bangMaPhuongRutGon;
        }
        // Hiển thị data bảng
        public static void InDataBang(int[,] Array)
        {
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write($"{Array[i, j],-3} |");
                }
                Console.WriteLine();
            }
        }   
    }
}
