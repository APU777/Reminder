using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_2_
{
    internal static partial class WorkShopAction
    {
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
