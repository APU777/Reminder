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
        private bool _CheckSize = false; // Check size of the MainWindow.
        private double _ScreenSizeWidth = SystemParameters.PrimaryScreenWidth; //Receives width of the screen.
        private bool _NotifyIconCheck = false; // Check size of the NotifyIcon(_NI)
        private UseOneTime _USO = new UseOneTime();
        public MainWindow()
        {
            InitializeComponent();          
            ////////////////////////////////////
            _Status(false, Visibility.Hidden); // Here i turn off of the visibility status for the text window.
            ///////////////////////////////////
            Title = "Reminder";
            //////////////////////////////////
            _USO.CreateGRID(_ROW:10, _COLUMN:30, _ListBox:ListBoxC1);
        }

        private void TextBox_Scroll(object sender, ScrollEventArgs e)
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
            foreach (Label LBC1 in ListBoxC1.Items)
            {
                LBC1.Width = ListBoxC1.ActualWidth - 30;
                LBC1.Height = 100;
                LBC1.Margin = new Thickness(2);
                ///////////////////////////////////
                if ( ((int)ActualWidth - ((int)ActualWidth - _ScreenSizeWidth)) == _ScreenSizeWidth && _CheckSize)
                    _CheckSize = !_CheckSize;
                if (ActualWidth < ((_ScreenSizeWidth * 98) / 100))
                    _CheckSize = true;
                ///////////////////////////////////
                //Title = ActualWidth.ToString();
                ///////////////////////////////////
                if (_CheckSize)
                {
                    ((TextBlock)((Grid)LBC1.Content).Children[4]).Text = ((TextBlock)((Grid)LBC1.Content).Children[4]).Text.Substring(0, 3);
                    ((TextBlock)((Grid)LBC1.Content).Children[6]).Text = ((TextBlock)((Grid)LBC1.Content).Children[6]).Text.Substring(0, 3);
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
                    ((TextBlock)((Grid)LBC1.Content).Children[4]).Text = "September";
                    ((TextBlock)((Grid)LBC1.Content).Children[6]).Text = "Wednesday";
                    Grid.SetColumnSpan(((Ellipse)((Grid)LBC1.Content).Children[0]), 6);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[1]), 6);
                    Grid.SetColumnSpan(((TextBlock)((Grid)LBC1.Content).Children[1]), 20);
                    Grid.SetColumn(((TextBlock)((Grid)LBC1.Content).Children[2]), 6);
                    Grid.SetColumnSpan(((TextBlock)((Grid)LBC1.Content).Children[2]), 20);
                }
            }
           _CheckSize = !_CheckSize;
        }


        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            _CheckStatus();
        }
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
                        if (!L_Save.IsEnabled)
                        {
                            _Status(true, Visibility.Visible);
                        }
                    }
                };
                LBC1.MouseRightButtonDown += delegate (object Sender, MouseButtonEventArgs E)
                {
                    if (L_Save.IsEnabled)
                    {
                        _Status(false, Visibility.Hidden);
                    }
                };
            }
        }

        private void ListBoxC1_MouseDown(object sender, MouseButtonEventArgs e)
        {
           
        }

        private void _Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _NotifyIconCheck = ActionsRM.CheckingClosing(e, this);
            ActionsRM.NotifyIcon(this, _NotifyIconCheck);
        }

        private void _Window_StateChanged(object sender, EventArgs e)
        {
        }
    }


}
