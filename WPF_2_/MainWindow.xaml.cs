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
                UniformGrid uniform = new UniformGrid();
             
                Label d = new Label();
                d.Background = Brushes.WhiteSmoke;
                d.BorderBrush = Brushes.Black;
                d.BorderThickness = new Thickness(5);
                d.Content = uniform;
                uniform.Rows = 2;
                uniform.Columns = 14;
                Rectangle s = new Rectangle();
                s.Width = 50;
                s.Height = 50;
                s.Fill = Brushes.Red;
                uniform.Children.Add(s);
                uniform.Children.Add(new TextBlock(new Run("123")));

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
