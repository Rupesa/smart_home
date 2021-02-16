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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InitialPage initial = new InitialPage();

            initial.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rooms r = new Rooms();
            r.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StatisticsWindow statistics = new StatisticsWindow();

            statistics.Show();
            this.Close();
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InitialPage initial = new InitialPage();

            initial.Show();
            this.Close();
        }
    }
}
