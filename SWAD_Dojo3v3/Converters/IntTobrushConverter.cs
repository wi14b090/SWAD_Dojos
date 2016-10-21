﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace SWAD_Dojo3v3.Converters
{
    public class IntTobrushConverter : IValueConverter
    {

        Brush red = new SolidColorBrush(Colors.Red);
        Brush yellow = new SolidColorBrush(Colors.Yellow);
        Brush green = new SolidColorBrush(Colors.Green);

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //Add convertion code here!!
            int val = (int)value;
            if (val > 20) { return green; }
            else if (val < 10) { return red; }
            else { return yellow; }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            //forget this! only for convertion back 
            throw new NotImplementedException();
        }
    }
}
