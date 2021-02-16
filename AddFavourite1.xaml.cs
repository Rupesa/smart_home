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
    /// Interaction logic for AddFavourite1.xaml
    /// </summary>
    public partial class AddFavourite1 : Window
    {
        InitialPage iPage;
        public AddFavourite1(InitialPage ip)
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

        private void goBack(object sender, RoutedEventArgs e)
        {
            iPage.Show();
            this.Hide();

        }

        private void goBack2(object sender, RoutedEventArgs e)
        {
            AddFavourite2 ap2 = new AddFavourite2(iPage);
            ap2.Show();
            this.Hide();

        }

        private void addFavourite(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            String a = b.Name;
            if (b.Name.Equals("button2"))
            {
                iPage.addFavourite2("blind", "Living Room\nBlind 1");
            } else if (b.Name.Equals("button1"))
            {
                iPage.addFavourite2("bulb", "Living Room\nLigths");
            }
            else if (b.Name.Equals("button3"))
            {
                iPage.addFavourite2("blind", "Living Room\nBlind 2");
            }
            else if (b.Name.Equals("button4"))
            {
                iPage.addFavourite2("speaker", "Living Room\nBose");
            }
            iPage.Show();
            this.Hide();
        }

    }

}
