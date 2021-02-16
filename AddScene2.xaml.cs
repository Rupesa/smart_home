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
    /// Interaction logic for AddScene2.xaml
    /// </summary>
    public partial class AddScene2 : Window
    {
        InitialPage iPage;
        AddScene1 addS1;
        public AddScene2(InitialPage ip, AddScene1 ac)
        {
            InitializeComponent();
            iPage = ip;
            addS1 = ac;
        }

        private void goToStats(object sender, RoutedEventArgs e)
        {
            StatisticsWindow stats = new StatisticsWindow();
            stats.Show();
            this.Hide();

        }

        private void goToRooms(object sender, RoutedEventArgs e)
        {
            Rooms rooms = new Rooms();
            rooms.Show();
            this.Hide();

        }

        private void goNext(object sender, RoutedEventArgs e)
        {
            addS1.showOk();
            addS1.Show();
            this.Hide();

        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            addS1.Show();
            this.Hide();

        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            iPage.Show();
            this.Hide();

        }

        private void act1(object sender, RoutedEventArgs e)
        {
            if (sw1.Visibility.Equals(Visibility.Visible))
            {
                sw1.Visibility = Visibility.Hidden;
            } else
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

    }
}
