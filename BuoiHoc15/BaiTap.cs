using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc15
{
    public interface ActionRest
    {
        void Rest();
    }
    public interface Action
    {
        void Run();
    }
    public abstract class Animals : Action,ActionRest
    {
        string name;
        int age;
        string food;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Food { get => food; set => food = value; }

        abstract public void Run();
        public abstract void Rest();
    }

    public class Cat : Animals
    {
        public override void Rest()
        {
            Console.WriteLine("Mèo đang nghỉ");
        }
        public override void Run()
        {
            Console.WriteLine("Mèo đang chạy");
        }
    }
    public class Dog : Animals
    {
        public override void Rest()
        {
            Console.WriteLine("Chó đang nghỉ");
        }
        public override void Run()
        {
            Console.WriteLine("Chó đang chạy");
        }
    }

    public class People : Action
    {
        string name;
        int old;
        string address;
        string mobilePhone;

        public string Name { get => name; set => name = value; }
        public int Old { get => old; set => old = value; }
        public string Address { get => address; set => address = value; }
        public string MobilePhone { get => mobilePhone; set => mobilePhone = value; }

        public void Run()
        {
            Console.WriteLine("Bố mày đang chạy");
        }
    }
    public class MyCar : Action,ActionRest
    {
        string name;
        int old;
        string color;

        public string Name { get => name; set => name = value; }
        public int Old { get => old; set => old = value; }
        public string Color { get => color; set => color = value; }

        public void Rest()
        {
            Console.WriteLine("Xe đang đỗ");
        }
        public void Run()
        {
            Console.WriteLine("Xe đang chạy");
        }
    }
}
