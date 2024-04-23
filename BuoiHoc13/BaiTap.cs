using System;
using System.Collections.Generic;
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
        private string name;
        private string birthday;
        private int salary;

        public string Name1 { get => name; set => name = value; }
        public string Birthday1 { get => birthday; set => birthday = value; }
        public int Salary1 { get => salary; set => salary = value; }

        //public Person(string ten, string sinhnhat, int luong)
        //{
        //    name = ten;
        //    birthday = sinhnhat;
        //    salary = luong;
        //}
    }

}
