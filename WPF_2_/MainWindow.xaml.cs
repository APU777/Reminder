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
        public void _Status(bool _Look, Visibility _VISIB)
        {
            L_Save.IsEnabled = _Look;
            L_Save.Visibility = _VISIB;
            L_Color.IsEnabled = _Look;
            L_Color.Visibility = _VISIB;
            L_Bold.IsEnabled = _Look;
            L_Bold.Visibility = _VISIB;
            L_TextSize.IsEnabled = _Look;
            L_TextSize.Visibility = _VISIB;
            E_CircleFrame.IsEnabled = _Look;
            E_CircleFrame.Visibility = _VISIB;
            T_Title.IsEnabled = _Look;
            T_Title.Visibility = _VISIB;
            L_TimeTitle.IsEnabled = _Look;
            L_TimeTitle.Visibility = _VISIB;
            L_DateTitle.IsEnabled = _Look;
            L_DateTitle.Visibility = _VISIB;
            TextBoxBigTEXT_BLOB.IsEnabled = _Look;
            TextBoxBigTEXT_BLOB.Visibility = _VISIB;
            L_TimeFuture.IsEnabled = _Look;
            L_TimeFuture.Visibility = _VISIB;
            B_Plus.IsEnabled = _Look;
            B_Plus.Visibility = _VISIB;
            B_Minus.IsEnabled = _Look;
            B_Minus.Visibility = _VISIB;
            L_MonthFuture.IsEnabled = _Look;
            L_MonthFuture.Visibility = _VISIB;
            DP_DateFuture.IsEnabled = _Look;
            DP_DateFuture.Visibility = _VISIB;
        }
        public void _CheckStatus()
        {
                foreach (Label LBC1 in ListBoxC1.Items)
                {
                    LBC1.MouseLeftButtonDown += delegate (object Sender, MouseButtonEventArgs E)
                    {
                        if (LBC1.IsMouseOver)
                        {
                            if(!L_Save.IsEnabled)
                                _Status(true, Visibility.Visible);
                        }
                    };
                    LBC1.MouseRightButtonDown += delegate (object Sender, MouseButtonEventArgs E)
                    {
                        if (L_Save.IsEnabled)
                            _Status(false, Visibility.Hidden);
                    };
                }
        }
        public MainWindow()
        {
            InitializeComponent();
            L_Bold.Visibility = Visibility.Hidden;
            ////////////////////////////////////
            _Status(false, Visibility.Hidden);
            ///////////////////////////////////
            Title = "Reminder";
            for (int i = 0; i < 10; ++i)
            {
                Grid grid = new Grid();
                grid.ShowGridLines = false;
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
                O_Ellipse.Fill = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\Admin\Documents\Visual Studio 2017\Projects\Reminder\WPF_2_\Image\mrPcoZytokQ.jpg", UriKind.Relative)));
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBTitle = new TextBlock();
                TBTitle.Text = "1234567891011121314151617181920";
                TBTitle.FontFamily = new FontFamily("Comic Sans MS");
                TBTitle.FontSize = 27;
                TBTitle.TextWrapping = TextWrapping.Wrap;
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
                TBYear.FontSize = 17;
                TBYear.TextAlignment = TextAlignment.Center;
                //TBYear.Background = Brushes.Pink;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBMonth = new TextBlock();
                TBMonth.Text = "September";
                TBMonth.FontFamily = new FontFamily("Comic Sans MS");
                TBMonth.FontSize = 12;
                TBMonth.FontWeight = FontWeights.Bold;
                TBMonth.TextAlignment = TextAlignment.Center;
               // TBMonth.Background = Brushes.Pink;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBDay = new TextBlock();
                TBDay.Text = "30";
                TBDay.FontFamily = new FontFamily("Comic Sans MS");
                TBDay.FontSize = 20;
                TBDay.FontWeight = FontWeights.Bold;
                TBDay.TextAlignment = TextAlignment.Center;
             //   TBDay.Background = Brushes.Pink;
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                TextBlock TBTxDay = new TextBlock();
                TBTxDay.Text = "Wednesday";
                TBTxDay.FontFamily = new FontFamily("Comic Sans MS");
                TBTxDay.FontSize = 12;
                TBTxDay.FontWeight = FontWeights.Bold;
                TBTxDay.TextAlignment = TextAlignment.Center;
              //  TBTxDay.Background = Brushes.Pink;
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
                Grid.SetRowSpan(TBYear, 3);
                Grid.SetColumn(TBYear, 26);
                Grid.SetColumnSpan(TBYear, 4);
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                Grid.SetRow(TBMonth, 3);
                Grid.SetRowSpan(TBMonth, 3);
                Grid.SetColumn(TBMonth, 26);
                Grid.SetColumnSpan(TBMonth, 4);
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                Grid.SetRow(TBDay, 5);
                Grid.SetRowSpan(TBDay, 3);
                Grid.SetColumn(TBDay, 26);
                Grid.SetColumnSpan(TBDay, 4);
                /*------------------------------------------------------------------------------------------------------------------------------------------------------------*/
                Grid.SetRow(TBTxDay, 8);
                Grid.SetRowSpan(TBTxDay, 2);
                Grid.SetColumn(TBTxDay, 26);
                Grid.SetColumnSpan(TBTxDay, 4);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                grid.Children.Add(O_Ellipse);
                grid.Children.Add(TBTitle);
                grid.Children.Add(TBText);
                grid.Children.Add(TBYear);
                grid.Children.Add(TBMonth);
                grid.Children.Add(TBDay);
                grid.Children.Add(TBTxDay);
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //grid.Background = Brushes.Blue;
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
                    Grid.SetColumnSpan(((TextBlock)((Grid)LBC1.Content).Children[1]), 18);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[2]), 8);
                    Grid.SetColumnSpan(((TextBlock)((Grid)LBC1.Content).Children[2]), 18);
                    ((TextBlock)((Grid)LBC1.Content).Children[4]).Text = ((TextBlock)((Grid)LBC1.Content).Children[4]).Text.Substring(0, 3);
                    ((TextBlock)((Grid)LBC1.Content).Children[6]).Text = ((TextBlock)((Grid)LBC1.Content).Children[6]).Text.Substring(0, 3);

                }
                else
                {
                    Grid.SetColumnSpan(((Ellipse)((Grid)LBC1.Content).Children[0]), 6);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[1]), 6);
                    Grid.SetColumnSpan(((TextBlock)((Grid)LBC1.Content).Children[1]), 20);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[2]), 6);
                    Grid.SetColumnSpan(((TextBlock)((Grid)LBC1.Content).Children[2]), 20);
                    ((TextBlock)((Grid)LBC1.Content).Children[4]).Text = "September";
                    ((TextBlock)((Grid)LBC1.Content).Children[6]).Text = "Wednesday";
                }
            }
           _CheckSize = !_CheckSize;
        }



   
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            _CheckStatus();

        }
    }

   
}
