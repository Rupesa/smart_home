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
    /// Interaction logic for AddScene3.xaml
    /// </summary>
    public partial class AddScene3 : Window
    {
        InitialPage iPage;
        AddScene1 addS1;
        public AddScene3(InitialPage ip, AddScene1 ac)
        {
            InitializeComponent();
            addS1 = ac;
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

        private void goNext(object sender, RoutedEventArgs e)
        {
            AddScene4 ac4 = new AddScene4(iPage, this, tbox.Text);
            ac4.Show();
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

    }
}