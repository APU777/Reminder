using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Media;


namespace WPF_2_
{
    internal static partial class WorkShopAction
    {
        static Label f;

        public static void ContextMenu_NI(System.Windows.Forms.ContextMenu _CM, System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            System.Windows.Forms.MenuItem _MI = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem _MI1 = new System.Windows.Forms.MenuItem();

            _CM.MenuItems.AddRange(items: new System.Windows.Forms.MenuItem[] { _MI });
            _CM.MenuItems.AddRange(items: new System.Windows.Forms.MenuItem[] { _MI1 });

            ShowMWindowFromTray(_MI, _NotifyIcon, _THIS);
            CloseMWindowFromTray(_MI1, _NotifyIcon, _THIS);
        }
        public static void NIDoubleClick(System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            if (_THIS == null)
            {
                throw new ArgumentNullException(nameof(_THIS));
            }

            _NotifyIcon.DoubleClick += delegate (object sender, EventArgs args)
            {
                ShowW_NIoff(_NotifyIcon, _THIS);
            };
        }
        public static void Pause_ForCreate(out Timer _T,  ref Label _ChangeImageEllipse)
        {
            f = _ChangeImageEllipse;
            _T = new Timer(2000);
             //_T.Elapsed += EllipseVisible_Tick;
             _T.Elapsed += (sender, e) =>  ((Ellipse)f.Content).Visibility = Visibility.Visible;
            _T.AutoReset = false;
            _T.Start();

        }
        private static void EllipseVisible_Tick(object Sender, ElapsedEventArgs E)
        {
            if (Sender == null)
            {
                throw new ArgumentNullException(nameof(Sender));
            }

               MessageBox.Show("The Elapsed event was raised at { " + E.SignalTime.ToString() + " }");
                MessageBox.Show("1");
                ((Ellipse)f.Content).Visibility = Visibility.Visible;

            //if (_MW._Im)
            //    _MW._CIEllipse.Visibility = Visibility.Visible;
            //else
            //   _MW._CIEllipse.Visibility = Visibility.Hidden;
        }
        private static void ShowW_NIoff(System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            _THIS.Show();
            _THIS.WindowState = WindowState.Normal;
            _NotifyIcon.Visible = false;
        }
        private static void ShowMWindowFromTray(System.Windows.Forms.MenuItem _MI, System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            _MI.Index = 0;
            _MI.Text = "Show";
            _MI.Click += delegate (object Sender, EventArgs args)
            {
                ShowW_NIoff(_NotifyIcon, _THIS);
            };
        }
        private static void CloseMWindowFromTray(System.Windows.Forms.MenuItem _MI, System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            _MI.Index = 1;
            _MI.Text = "Exit";
            _MI.Click += delegate (object Sender, EventArgs args)
            {
                _THIS.Close();
            };
        }
    }
}
