using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Dojo3.Converters
{
    public class ColourConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                int temp = int.Parse(value.ToString());
                if (temp >= 20)
                {
                    return new SolidColorBrush(Colors.Green);
                }
                else if (temp >= 10)
                {
                    return new SolidColorBrush(Colors.Orange);
                }
                else { return new SolidColorBrush(Colors.Red); }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
