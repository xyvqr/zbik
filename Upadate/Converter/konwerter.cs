using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Upadate.Converter
{
    class konwerter : IValueConverter
    {
        public object Convert(object value, Type targerType, object parametr, CultureInfo culture)
        {
            int wartosc = System.Convert.ToInt32(value);


            if (wartosc == 0)
            {
                return "zero";
            }
            else if (wartosc == 2)
            {
                return "dwa";
            }else if(wartosc == 1)
            {
                return "jeden";
            }
            else if (wartosc == 2)
            {
                return "dwa";
            }
            else if (wartosc == 3)
            {
                return "trzy";
            }
            else if (wartosc == 5)
            {
                return "piec";
            }
            return "";
        }
        

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}


