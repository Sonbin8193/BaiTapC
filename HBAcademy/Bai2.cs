using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    internal class Test1
    {
        internal static void Hello()
        {
            Console.WriteLine("How are you my friend");
        }
    }
    namespace Bai2Child
    {
        internal class Test2
        {
            internal static void Hello()
            {
                Console.WriteLine("I am fine, thanks");
            }
        }

        internal class Retangle
        {
            public static int GanGiaTriHinhChuNhat(int a,int b)
            {
                int chieuDai=a;
                int chieuRong=b;
                Console.WriteLine("Chieu dai hinh chu nhat la " + chieuDai);
                Console.WriteLine("Chieu rong hinh chu nhat la " + chieuRong);
            }
        }
    }

}

