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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mod2Lab17
{
    /// <summary>
    /// Логика взаимодействия для ColorSlider.xaml
    /// </summary>
    /// 


    public partial class ColorSlider : UserControl
    {
        public static readonly DependencyProperty Color

        public static readonly DependencyProperty RedProperty =
        DependencyProperty.Register(
            nameof(Red),
            typeof(byte),
            typeof(ColorSlider),
            new FrameworkPropertyMetadata(
                default(byte),
                0,
                null,
                new CoerceValueCallback(CoerceColor)
                )
            );

        private static object CoerceColor(DependencyObject d, object baseValue)
        {
            byte color = (byte)baseValue;
            if (color < 0)
            {
                return 0;
            }
            if (color > 255)
            {
                return 255;
            }
            return color;
        }

        public byte Red
        {
            get => (byte)GetValue(RedProperty);
            set => SetValue(RedProperty, value);
        }

        public static readonly DependencyProperty GreenProperty =
        DependencyProperty.Register(
            nameof(Green),
            typeof(byte),
            typeof(ColorSlider),
            new FrameworkPropertyMetadata(
                default(byte),
                0,
                null,
                new CoerceValueCallback(CoerceColor)
                )
            );

        public byte Green
        {
            get => (byte)GetValue(GreenProperty);
            set => SetValue(GreenProperty, value);
        }

        public static readonly DependencyProperty BlueProperty =
        DependencyProperty.Register(
            nameof(Blue),
            typeof(byte),
            typeof(ColorSlider),
            new FrameworkPropertyMetadata(
                default(byte),
                0,
                null,
                new CoerceValueCallback(CoerceColor)
                )
            );

        public byte Blue
        {
            get => (byte)GetValue(BlueProperty);
            set => SetValue(BlueProperty, value);
        }
    

        public SolidColorBrush RectColor = new SolidColorBrush(Color.FromRgb((Red,Green,Blue);

        public ColorSlider()
        {
            
        }
    }
}
