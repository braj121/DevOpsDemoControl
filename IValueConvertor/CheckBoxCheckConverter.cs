using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace IValueConvertor
{
    public class CheckBoxCheckConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.ToString().ToUpper() == "MARRIED")
                return true;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool married = System.Convert.ToBoolean(value);
            if (married == true)
                return "Married";
            else
                return "Unmarried";
        }
    }
}
