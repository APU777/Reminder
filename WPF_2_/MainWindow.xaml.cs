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
        bool _CheckSize = false;
        public MainWindow()
        {
            InitializeComponent();
            Title = "Reminder";
         
            for (int i = 0; i < 10; ++i)
            {
                Grid grid = new Grid();
                grid.ShowGridLines = true;
                for(int j = 0; j < 30; ++j)
                {
                    ColumnDefinition ColD = new ColumnDefinition();
                    //ColD.Width = new GridLength(190, GridUnitType.Star);
                    grid.ColumnDefinitions.Add(ColD);
                    if (j < 10)
                    {
                        RowDefinition RowD = new RowDefinition();
                        grid.RowDefinitions.Add(RowD);
                    }
                }
              
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Ellipse O_Ellipse = new Ellipse();
                O_Ellipse.Width = 80;
                O_Ellipse.Height = 80;
                O_Ellipse.Fill = Brushes.Red;
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBTitle = new TextBlock();
                TBTitle.Text = "1234567891011121314151617181920";
                TBTitle.FontFamily = new FontFamily("Comic Sans MS");
                TBTitle.FontSize = 27;
                //TBTitle.Background = Brushes.Yellow;
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBText = new TextBlock();
                TBText.Text = "1234567891011121314151617181920";
                TBText.FontFamily = new FontFamily("Comic Sans MS");
                TBText.FontSize = 15;
                //TBText.Background = Brushes.Blue;
                TBText.TextWrapping = TextWrapping.Wrap;
                //  TBText.Width = 1000;
                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBYear = new TextBlock();
                TBYear.Text = "2018";
                TBYear.FontFamily = new FontFamily("Comic Sans MS");
                TBYear.FontSize = 15;
                TBYear.Background = Brushes.Pink;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Grid.SetRow(O_Ellipse, 0);
                Grid.SetRowSpan(O_Ellipse, 10);
                Grid.SetColumn(O_Ellipse, 0);
                Grid.SetColumnSpan(O_Ellipse, 6);
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                Grid.SetRow(TBTitle, 0);
                Grid.SetRowSpan(TBTitle, 5);
                Grid.SetColumn(TBTitle, 6);
                Grid.SetColumnSpan(TBTitle, 20);
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                Grid.SetRow(TBText, 5);
                Grid.SetRowSpan(TBText, 5);
                Grid.SetColumn(TBText, 6);
                Grid.SetColumnSpan(TBText, 20);
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                Grid.SetRow(TBYear, 0);
                Grid.SetRowSpan(TBYear, 2);
                Grid.SetColumn(TBYear, 27);
                Grid.SetColumnSpan(TBYear, 4);

                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


                grid.Children.Add(O_Ellipse);
                grid.Children.Add(TBTitle);
                grid.Children.Add(TBText);
                grid.Children.Add(TBYear);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                grid.Background = Brushes.Blue;
                Label d = new Label();
                d.Background = Brushes.WhiteSmoke;
                d.BorderBrush = Brushes.Black;
                d.BorderThickness = new Thickness(5);
                d.Content = grid;
                d.HorizontalContentAlignment = HorizontalAlignment.Stretch;

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
            foreach (Label LBC1 in ListBoxC1.Items)
            {
                LBC1.Width = ListBoxC1.ActualWidth - 30;
                LBC1.Height = 100;
                if (_CheckSize)
                {
                    Grid.SetColumnSpan(((Ellipse)((Grid)LBC1.Content).Children[0]), 8);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[1]), 8);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[2]), 8);
                }
            }
            _CheckSize = true;
        }
    }
}
