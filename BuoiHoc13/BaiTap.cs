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
        ~ Person()
        {
            Console.WriteLine("Hủy");
        }
    }

}
