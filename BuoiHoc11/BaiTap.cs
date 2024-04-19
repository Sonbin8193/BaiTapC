using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc11
{
    public class BaiTap1
    {
        public static void TaoDaySo()
        {
            Random random = new Random();
            int[] daySo = new int[1000];
            for (int i = 0; i < daySo.Length-1; i++)
            {
                daySo[i] = random.Next(1, 1001);
            }
            Console.WriteLine();
            int[] daySoSapXep = new int[1000];
            Array.Copy(daySo, daySoSapXep, daySo.Length);
            SapXepChon(daySoSapXep);
            SapXepChen(daySoSapXep);

        }
        public static void SapXepChon(int[] daySoSapXep)
        {
            int min;
            for (int i = 0; i < daySoSapXep.Length-1; i++)
            {
                min = daySoSapXep[i];
                Console.WriteLine();
                for (int j = i+1; j < daySoSapXep.Length-1; j++)
                {
                    if (min > daySoSapXep[j])
                    {
                        min = daySoSapXep[j];
                        daySoSapXep[j] = daySoSapXep[i];
                        daySoSapXep[i] = min;
                    }
                }
            }
            string string_daySoSapXep = "";
            for (int i = 0; i < daySoSapXep.Length-1; i++)
            {
                string_daySoSapXep += "," + (daySoSapXep[i]);

            }
            Console.WriteLine("Day So: " + string_daySoSapXep);
        }
        public static void SapXepChen(int[] daySoSapXep)
        {
            int j, x;
            for (int i = 0; i < daySoSapXep.Length - 1; i++)
            {
                x = daySoSapXep[i];
                j = i-1;
                while (j>=0 && daySoSapXep[j]>x)
                {
                    daySoSapXep[j + 1] = daySoSapXep[j];
                    j--;
                }
                daySoSapXep[j+1] = x;
            }
            string string_daySoSapXep = "";
            for (int i = 0; i < daySoSapXep.Length - 1; i++)
            {
                string_daySoSapXep += "," + (daySoSapXep[i]);

            }
            Console.WriteLine("Day So: " + string_daySoSapXep);
        }
    }
}
