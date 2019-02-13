using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IValueConvertor
{
    /// <summary>
    /// Interaction logic for DataConversion.xaml
    /// </summary>
    public partial class DataConversion : Window
    {
        public DataConversion()
        {
            InitializeComponent();
        }
    }
    public class AddConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType,
               object parameter, System.Globalization.CultureInfo culture)
        {
            int result =
                Int32.Parse((string)values[0]) + Int32.Parse((string)values[1]);
            return result.ToString();
        }
        public object[] ConvertBack(object value, Type[] targetTypes,
               object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException("Cannot convert back");
        }
    }

}
