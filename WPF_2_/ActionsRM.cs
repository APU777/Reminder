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

    public static partial class ActionsRM
    {
        public static void NotifyIcon(MainWindow _THIS, bool _NotifyIconCheck)
        {
            if (_NotifyIconCheck)
            {
                System.Windows.Forms.NotifyIcon _NI = new System.Windows.Forms.NotifyIcon();

                System.Windows.Forms.ContextMenu _CM = new System.Windows.Forms.ContextMenu();


                ContextMenu_NI(_CM, _NI, _THIS);

                Stream _SourceIcon = Application.GetResourceStream(new Uri("pack://application:,,,/WPF_2_;component/Image/mainicon.ico")).Stream;
                _NI.Icon = new System.Drawing.Icon(_SourceIcon);
                _NI.Visible = true;
                _NI.Text = "go";
                _NI.ContextMenu = _CM;
                NIDoubleClick(_NotifyIcon: _NI, _THIS: _THIS);
            }
        }
        public static bool CheckingClosing(System.ComponentModel.CancelEventArgs _E, MainWindow _THIS)
        {
            MessageBoxResult _Result = MessageBox.Show("Really close?", "Warning", MessageBoxButton.YesNo); //_Result become Yes || No.

            if (_Result == MessageBoxResult.No) //Check result.
            {
                if (_THIS.IsVisible == false)
                {
                    _E.Cancel = true;
                    return false;
                }
                    _E.Cancel = true; // Cancel close the window.
                    _THIS.Hide(); // Hide _THIS.%Window.
                    return true;
            }
            return false;
        }

        private static void ContextMenu_NI (System.Windows.Forms.ContextMenu _CM, System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            System.Windows.Forms.MenuItem _MI = new System.Windows.Forms.MenuItem();
            System.Windows.Forms.MenuItem _MI1 = new System.Windows.Forms.MenuItem();

            _CM.MenuItems.AddRange(items: new System.Windows.Forms.MenuItem[] { _MI });
            _CM.MenuItems.AddRange(items: new System.Windows.Forms.MenuItem[] { _MI1 });

            ShowMWindowFromTray(_MI, _NotifyIcon, _THIS);
            CloseMWindowFromTray(_MI1, _NotifyIcon, _THIS);
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
        private static void  NIDoubleClick(System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
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
        private static void ShowW_NIoff(System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            _THIS.Show();
            _THIS.WindowState = WindowState.Normal;
            _NotifyIcon.Visible = false;
        }
    }


}
