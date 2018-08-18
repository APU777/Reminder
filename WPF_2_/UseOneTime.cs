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
using System.IO;

namespace WPF_2_
{
    class UseOneTime
    {
        public void CreateGRID(int _ROW, int _COLUMN, ref ListBox _ListBox)
        {
            for (int i = 0; i < 10; ++i)
            {
                Grid grid = new Grid();
                grid.ShowGridLines = false;
                for (int j = 0; j < _COLUMN;/*30 Column*/ ++j)     //Creating GRID in Items on the ListBox.
                {
                    ColumnDefinition ColD = new ColumnDefinition(); //Creating Columns in the GRID.
                    grid.ColumnDefinitions.Add(ColD); // Add column in the GRID.
                    if (j < _ROW/*10*/)
                    {
                        RowDefinition RowD = new RowDefinition(); //Creating Rows in the GRID.
                        grid.RowDefinitions.Add(RowD); //Add row in the GRID.
                    }
                }
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Ellipse O_Ellipse = new Ellipse();
                O_Ellipse.Width = 80;
                O_Ellipse.Height = 80;
                //O_Ellipse.Fill = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\User\Desktop\Reminder\WPF_2_\Image\mrPcoZytokQ.jpg", UriKind.Relative)));
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
                Label L = new Label();
                L.Background = Brushes.Snow;
                //   d.BorderBrush = Brushes.Black;
                L.BorderThickness = new Thickness(5);
                L.Content = grid;
                L.HorizontalContentAlignment = HorizontalAlignment.Stretch;

                _ListBox.Items.Add(L);
            }

        }
        public void CreateEllipseLabelGRID(ref Ellipse _Ellipse, ref Label _CI, ref Grid _Grid)
        {
            if (_Grid == null)
            {
                throw new ArgumentNullException(nameof(_Grid));
            }

                _Ellipse.Width = 30;
                _Ellipse.Height = 30;
                _Ellipse.Fill = Brushes.Red;
                _Ellipse.Visibility = Visibility.Hidden;
                _CI.Content = _Ellipse;
                _Grid.Children.Add(_CI);
            Grid.SetRow(_CI, 0);
            Grid.SetRowSpan(_CI, 2);
        }
    }
}
