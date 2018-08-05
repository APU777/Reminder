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
                Stream _SourceIcon = Application.GetResourceStream(new Uri("pack://application:,,,/WPF_2_;component/Image/ball-6x6.ico")).Stream;
                _NI.Icon = new System.Drawing.Icon(_SourceIcon);
                _NI.Visible = true;
                _NI.Text = "go";
                // ni.ContextMenu =
                NIDoubleClick(_NotifyIcon: _NI, _THIS: _THIS);
            }    
        }
        private static void  NIDoubleClick(System.Windows.Forms.NotifyIcon _NotifyIcon, MainWindow _THIS)
        {
            if (_THIS == null)
            {
                throw new ArgumentNullException(nameof(_THIS));
            }

            _NotifyIcon.DoubleClick += delegate (object sender, EventArgs args)
            {
                _THIS.Show();
                _THIS.WindowState = WindowState.Normal;
                _NotifyIcon.Visible = false;
            };
        }
        public static bool CheckingClosing(System.ComponentModel.CancelEventArgs _E, MainWindow _THIS)
        {
            MessageBoxResult _Result = MessageBox.Show("Really close?", "Warning", MessageBoxButton.YesNo); //_Result become Yes || No.

            if (_Result == MessageBoxResult.No) //Check result.
            {
                _E.Cancel = true; // Cancel close the window.
                _THIS.Hide(); // Hide _THIS.%Window.
                return true;
            }
            return false;
          }
    }
}
