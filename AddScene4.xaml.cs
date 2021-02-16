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
    /// Interaction logic for AddScene4.xaml
    /// </summary>
    public partial class AddScene4 : Window
    {
        InitialPage iPage;
        AddScene3 addS3;
        String title;
        public AddScene4(InitialPage ip, AddScene3 ac, String txt)
        {
            InitializeComponent();
            iPage = ip;
            addS3 = ac;
            title = txt;
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

        private void goBack(object sender, RoutedEventArgs e)
        {
            addS3.Show();
            this.Hide();

        }

        private void goHome(object sender, RoutedEventArgs e)
        {
            iPage.Show();
            this.Hide();

        }

        private void act1(object sender, RoutedEventArgs e)
        {
            iPage.addSceneFinal(title, "sun");
            iPage.Show();
            this.Hide();
        }

        private void act2(object sender, RoutedEventArgs e)
        {
            iPage.addSceneFinal(title, "moon");
            iPage.Show();
            this.Hide();
        }

        private void act3(object sender, RoutedEventArgs e)
        {
            iPage.addSceneFinal(title, "volume");
            iPage.Show();
            this.Hide();
        }

        private void act4(object sender, RoutedEventArgs e)
        {
            iPage.addSceneFinal(title, "popcorn");
            iPage.Show();
            this.Hide();
        }

        private void act5(object sender, RoutedEventArgs e)
        {
            iPage.addSceneFinal(title, "film");
            iPage.Show();
            this.Hide();
        }

    }
}
