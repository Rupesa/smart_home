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

namespace IHCProject
{
    /// <summary>
    /// Interaction logic for InitialPage.xaml
    /// </summary>
    public partial class InitialPage : Window
    {
        private Boolean[] clicked = { false, false, false, false, false, false, false, false};

        public InitialPage()
        {
            InitializeComponent();
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

        private void showMenu(object sender, RoutedEventArgs e)
        {
            users.Visibility = Visibility.Visible;
            back.Visibility = Visibility.Visible;
        }

        private void showInfo1(object sender, RoutedEventArgs e)
        {
            back.Visibility = Visibility.Visible;
            rectangle1.Visibility = Visibility.Visible;
            infoL1.Visibility = Visibility.Visible;
        }

        private void showInfo2(object sender, RoutedEventArgs e)
        {
            back.Visibility = Visibility.Visible;
            rectangle2.Visibility = Visibility.Visible;
            infoL2.Visibility = Visibility.Visible;
        }

        private void showNot(object sender, RoutedEventArgs e)
        {
            Notifications not = new Notifications(this);
            not.Show();
            this.Hide();
        }

        private void addScene(object sender, RoutedEventArgs e)
        {
            AddScene1 not = new AddScene1(this);
            not.Show();
            this.Hide();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            users.Visibility = Visibility.Hidden;
            b.Visibility = Visibility.Hidden;
            rectangle1.Visibility = Visibility.Hidden;
            infoL1.Visibility = Visibility.Hidden;
            rectangle2.Visibility = Visibility.Hidden;
            infoL2.Visibility = Visibility.Hidden;

        }

        private void addFavourite1(object sender, RoutedEventArgs e)
        {
            AddFavourite2 af = new AddFavourite2(this);
            af.Show();
            this.Hide();
        }

        public void addSceneFinal(String title, String img)
        {
            if (add2.Visibility.Equals(Visibility.Visible))
            {
                add2.Visibility = Visibility.Hidden;
                label2.Content = title;
                img2.Source = new BitmapImage(new Uri("Resources/" + img + ".png", UriKind.Relative));
                button2.Click -= addScene;
                button2.Click += changeColor2;
                button3.Visibility = Visibility.Visible;
            } else
            {
                add3.Visibility = Visibility.Hidden;
                label3.Content = title;
                img3.Source = new BitmapImage(new Uri("Resources/" + img + ".png", UriKind.Relative));
                button3.Click -= addScene;
                button3.Click += changeColor3;
            }
        }

        public void addFavourite2(String img, String name)
        {
            if (label62.Content.Equals(""))
            {
                add6.Visibility = Visibility.Hidden;
                label61.Content = name;
                img6.Source = new BitmapImage(new Uri("Resources/" + img + ".png", UriKind.Relative));
                if (img.Equals("blind"))
                {
                    label62.Content = "Closed";
                }
                else
                {
                    label62.Content = "Off";

                }
                button6.Click -= addFavourite1;
                button6.Click += changeColor6;
                button7.Visibility = Visibility.Visible;
            } else
            {
                add7.Visibility = Visibility.Hidden;
                label71.Content = name;
                img7.Source = new BitmapImage(new Uri("Resources/" + img + ".png", UriKind.Relative));
                if (img.Equals("blind"))
                {
                    label72.Content = "Closed";
                }
                else
                {
                    label72.Content = "Off";

                }
                button7.Click -= addFavourite1;
                button7.Click += changeColor7;
            }
        }

            private void changeColor0(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[0])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
            } else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
            }
            clicked[0] = !clicked[0];
        }

        private void changeColor1(object sender, RoutedEventArgs e)
        {
            int i = 1;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[i])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
            }
            clicked[i] = !clicked[i];
        }

        private void changeColor2(object sender, RoutedEventArgs e)
        {
            int i = 2;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[i])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
            }
            clicked[i] = !clicked[i];
        }

        private void changeColor3(object sender, RoutedEventArgs e)
        {
            int i = 3;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[i])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
            }
            clicked[i] = !clicked[i];
        }

        private void changeColor4(object sender, RoutedEventArgs e)
        {
            int i = 4;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[4])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
                current.Content = "Off";
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
                current.Content = "On";
            }
            clicked[i] = !clicked[i];
        }

        private void changeColor5(object sender, RoutedEventArgs e)
        {
            int i = 5;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[i])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
                garage.Content = "Closed";
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
                garage.Content = "Open";
            }
            clicked[i] = !clicked[i];
        }

        private void changeColor6(object sender, RoutedEventArgs e)
        {
            int i = 6;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[i])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
                if (label62.Content.Equals("Open"))
                {
                    label62.Content = "Closed";
                }
                else
                {
                    label62.Content = "Off";
                }
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
                if (label62.Content.Equals("Closed"))
                {
                    label62.Content = "Open";
                }
                else
                {
                    label62.Content = "On";
                }

            }
            clicked[i] = !clicked[i];
        }

        private void changeColor7(object sender, RoutedEventArgs e)
        {
            int i = 7;
            Button b = (Button)sender;
            BrushConverter bc = new BrushConverter();
            if (clicked[i])
            {
                b.Background = (Brush)bc.ConvertFrom("#FFDADADA");
                if (label72.Content.Equals("Open"))
                {
                    label72.Content = "Closed";
                }
                else
                {
                    label72.Content = "Off";
                }
            }
            else
            {
                b.Background = (Brush)bc.ConvertFrom("#FFA9A9A9");
                if (label72.Content.Equals("Closed"))
                {
                    label72.Content = "Open";
                }
                else
                {
                    label72.Content = "On";
                }

            }
            clicked[i] = !clicked[i];
        }

        private void showSettings(object sender, RoutedEventArgs e)
        {
            Settings st = new Settings();

            st.Show();
            this.Close();
        }

    }
}
