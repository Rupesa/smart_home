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

namespace IHCProject
{
    /// <summary>
    /// Interaction logic for Rooms_living.xaml
    /// </summary>
    public partial class Rooms_living : Window
    {
        public Rooms_living()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rooms rooms = new Rooms();

            rooms.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (sw1.Visibility.Equals(Visibility.Visible))
            {
                sw1.Visibility = Visibility.Hidden;
            }
            else
            {
                sw1.Visibility = Visibility.Visible;
            }
        }

        private void act1(object sender, RoutedEventArgs e)
        {
            if (sw1.Visibility.Equals(Visibility.Visible))
            {
                sw1.Visibility = Visibility.Hidden;
            }
            else
            {
                sw1.Visibility = Visibility.Visible;
            }
        }

        private void act2(object sender, RoutedEventArgs e)
        {
            if (sw2.Visibility.Equals(Visibility.Visible))
            {
                sw2.Visibility = Visibility.Hidden;
            }
            else
            {
                sw2.Visibility = Visibility.Visible;
            }
        }

        private void act3(object sender, RoutedEventArgs e)
        {
            if (sw3.Visibility.Equals(Visibility.Visible))
            {
                sw3.Visibility = Visibility.Hidden;
            }
            else
            {
                sw3.Visibility = Visibility.Visible;
            }
        }

        private void act4(object sender, RoutedEventArgs e)
        {
            if (sw4.Visibility.Equals(Visibility.Visible))
            {
                sw4.Visibility = Visibility.Hidden;
            }
            else
            {
                sw4.Visibility = Visibility.Visible;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InitialPage ip = new InitialPage();

            ip.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            StatisticsWindow statistics = new StatisticsWindow();

            statistics.Show();
            this.Close();
        }
    }
}
