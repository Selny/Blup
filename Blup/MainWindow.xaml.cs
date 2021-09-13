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

namespace Blup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int order { get; set; } = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private void got_Focus(object sender, RoutedEventArgs e)
        {
            type.Visibility = Visibility.Hidden;
        }

        private void lost_Focus(object sender, RoutedEventArgs e)
        {
            type.Visibility = Visibility.Visible;
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            OnKeyDownHandler(sender, null);
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (sender is Button || e.Key == Key.Enter)
            {
                msg1.Visibility = Visibility.Visible;
                if (order == 0)
                {
                    gmsg1.Visibility = Visibility.Visible;
                    msg1.Text = MsgBox.Text;
                    order++;
                    gmsg1_r.Visibility = Visibility.Visible;
                    if (MsgBox.Text.Contains("Salam")) msg1_r.Text = "Aleykum Salam";
                    else msg1_r.Text = "Yaxsiyam";
                }
                else if (order == 1)
                {
                    gmsg2.Visibility = Visibility.Visible;
                    msg2.Text = MsgBox.Text;
                    order++;
                    gmsg2_r.Visibility = Visibility.Visible;

                    if (MsgBox.Text.Contains("Salam")) msg2_r.Text = "Aleykum Salam";
                    else msg2_r.Text = "Muellim sizi Tural sensei caqira bilerem? :)";
                }
                else if (order == 2)
                {
                    gmsg3.Visibility = Visibility.Visible;
                    msg3.Text = MsgBox.Text;
                    gmsg3_r.Visibility = Visibility.Visible;

                    if (MsgBox.Text.Contains("Salam")) msg3_r.Text = "Aleykum Salam";
                    else msg3_r.Text = "Acmisam";
                }
                MsgBox.Text = "";
                type.Visibility = Visibility.Hidden;
            }
        }
    }
}
