using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuoiHoc12
{
    public class NhanVien
    {
        public string _name { get; set; }

        private string _date;

        public string Get_date()
        {
            return _date;
        }

        public void Set_date(string value)
        {
            DateOnly result;
            if (DateOnly.TryParse(value, out result))
            {
                _date = value;
            }
        }

        private string _country { get; set; }
        private double _salary { get; set; }
        private double _money { get; set; }

        public string ChuanHoaTen()
        {
            for (int i = 0; i < _name.Length-1; i++)
            {
                if (_name[i]==' ')
                {
                   
                }
            }
            return _name;
        }
    }
}
