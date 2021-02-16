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
    /// Interaction logic for AddScene1.xaml
    /// </summary>
    public partial class AddScene1 : Window
    {
        InitialPage iPage;
        public AddScene1(InitialPage ip)
        {
            InitializeComponent();
            iPage = ip;
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

        private void goLR(object sender, RoutedEventArgs e)
        {
            AddScene2 af = new AddScene2(iPage, this);
            af.Show();
            this.Hide();

        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            iPage.Show();
            this.Hide();

        }

        private void goNext(object sender, RoutedEventArgs e)
        {
            AddScene3 ac3 = new AddScene3(iPage, this);
            ac3.Show();
            this.Hide();

        }

        public void showOk()
        {
            ok.Visibility = Visibility.Visible;
        }
    }
}
