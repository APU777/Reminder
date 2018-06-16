using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_2_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "Reminder";
            //MessageBox.Show(ListBoxC1.ActualHeight.ToString());
         
            for (int i = 0; i < 10; ++i)
            {
                Grid grid = new Grid();
                grid.ShowGridLines = true;
                for(int j = 0; j < 30; ++j)
                {
                    ColumnDefinition ColD = new ColumnDefinition();
                    grid.ColumnDefinitions.Add(ColD);
                    if (j < 10)
                    {
                        RowDefinition RowD = new RowDefinition();
                        grid.RowDefinitions.Add(RowD);
                    }
                }
                Label d = new Label();
                d.Background = Brushes.WhiteSmoke;
                d.BorderBrush = Brushes.Black;
                d.BorderThickness = new Thickness(5);
                d.Content = grid;
                
                 
                
                Ellipse s = new Ellipse();
                s.Width = 80;
                s.Height = 80;
                s.Fill = Brushes.Red;
                grid.Children.Add(s);
                TextBlock TB = new TextBlock();
                TB.Text = "1234567891011121314151617181920";
                //TB.FontSize
                TB.Background = Brushes.Yellow;
                TB.Width = 1000;
               
                Grid.SetRow(s, 0);
                Grid.SetRowSpan(s, 10);
                Grid.SetColumn(s, 0);
                Grid.SetColumnSpan(s, 8);

                Grid.SetRow(TB, 0);
                Grid.SetRowSpan(TB, 5);
                Grid.SetColumn(TB, 8);
                Grid.SetColumnSpan(TB, 17);


                //grid.Children.Add(s);

                 grid.Children.Add(TB);

                ListBoxC1.Items.Add(d);
            }
        }

        private void TextBox_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void ListBoxC1_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           // MessageBox.Show(ListBoxC1.ActualHeight.ToString());
            foreach (var LBC1 in ListBoxC1.Items)
            {
                //MessageBox.Show(((Button)LBC1).Width.ToString());
                ((Label)LBC1).Width = ListBoxC1.ActualWidth - 30;
                ((Label)LBC1).Height = 100;
            }
        }
    }
}
