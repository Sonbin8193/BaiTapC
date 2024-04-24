using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BuoiHoc13
{
    public class HinhChuNhat
    {
        public int ChieuDai { get; set; }
        public int ChieuRong { get; set; }
        public int TinhDienTich()
        {
            return ChieuDai * ChieuRong;
        }
        public static HinhChuNhat operator + (HinhChuNhat a, HinhChuNhat b)
        {
            HinhChuNhat c = new HinhChuNhat();
            c.ChieuDai = a.ChieuDai + b.ChieuDai;
            c.ChieuRong = a.ChieuRong + b.ChieuRong;
            return c;
        }
    }
    public class Person
    {
        public delegate double FuncDelegate(int a, out double b); // Delegate Func
        public delegate void ActionDelegate (string a); // Delegate Action
        public delegate bool PredicateDelegate(int a); //Delegate Predicate
        private string name;
        private string birthday;
        private int salary;
        private int gender;
        public string Name1 { get => name; set => name = value; }
        public string Birthday1 { get => birthday; set => birthday = value; }
        public int Salary1 { get => salary; set => salary = value; }
        public int Gender { get => gender; set => gender = value; }

        public Person(string ten, string sinhnhat, int luong, int gioitinh)
        {
            name = ten;
            birthday = sinhnhat;
            salary = luong;
            gender = gioitinh;
        }

        public double TangLuong (int luong, out double thuong)
        {
            thuong = luong*0.05;
            return thuong;
        }
        public void HienThiTen(string ten)
        {
            Console.WriteLine("Xin chào {0}", ten);
        }
        public bool KiemTraGioiTinh(int a)
        {
            bool result=true;
            if (a == 0)
            {
                result = true;
            }
            if (a == 1)
            {
                result = false;
            }
            return result;
        }
        ~Person()
        {
            Console.WriteLine("Hủy");
        }
    }
    public class HoVaTen
    {
        public delegate string NameDelegate(int i, string a, string b, string c);
        private string ho;
        private string tenDem;
        private string ten;

        public string Ho { get => ho; set => ho = value; }
        public string TenDem { get => tenDem; set => tenDem = value; }
        public string Ten { get => ten; set => ten = value; }

        public string HienThiTen(int i,string a, string b, string c)
        {
            string userName = "";
            switch (i)
            {
                case 1:
                    userName = a + " " + b + " " + c;
                    break;
                case 2:
                    userName = a.ToLower() +" "+ b.ToLower() +" "+ c.ToLower();
                        break;
                case 3:
                    userName = a.ToUpper() + " " + b.ToUpper() + " " + c.ToUpper();
                    break;
                case 4:
                    char[] _a = a.ToCharArray();
                    char[] _b = b.ToCharArray();
                    char[] _c = c.ToCharArray();
                    for (int j = 0; j < _a.Length; j++)
                    {
                        _a[j] = char.ToLower(_a[j]);
                    }

                    for (int j = 0; j < _b.Length; j++)
                    {
                        _b[j] = char.ToLower(_b[j]);
                    }

                    for (int j = 0; j < _c.Length; j++)
                    {
                        _c[j] = char.ToLower(_c[j]);
                    }

                    _a[0] = char.ToUpper(_a[0]);
                    _b[0] = char.ToUpper(_b[0]);
                    _c[0] = char.ToUpper(_c[0]);
                    string new_a = new string(_a);
                    string new_b = new string(_b);
                    string new_c = new string(_c);
                    userName = new_a + " " + new_b + " " + new_c;
                    break;
            }
            return userName;
        }
    }
}
