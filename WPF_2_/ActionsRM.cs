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
    internal static partial class ActionsRM
    {
        public static void NotifyIcon(MainWindow _THIS, ref bool _NotifyIconCheck)
        {
            if (_NotifyIconCheck)
            {
                System.Windows.Forms.NotifyIcon _NI = new System.Windows.Forms.NotifyIcon();

                System.Windows.Forms.ContextMenu _CM = new System.Windows.Forms.ContextMenu();

                WorkShopAction.ContextMenu_NI(_CM, _NI, _THIS);

                Stream _SourceIcon = Application.GetResourceStream(new Uri("pack://application:,,,/WPF_2_;component/Image/mainicon.ico")).Stream;
                _NI.Icon = new System.Drawing.Icon(_SourceIcon);
                _NI.Visible = true;
                _NI.Text = "go";
                _NI.ContextMenu = _CM;
                WorkShopAction.NIDoubleClick(_NotifyIcon: _NI, _THIS: _THIS);
            }
        }
        public static bool CheckingClosing(ref System.ComponentModel.CancelEventArgs _E, MainWindow _THIS)
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
        public static void Pause_ImageEllipseLabel(out System.Windows.Threading.DispatcherTimer _T, Label _CI)
        {
            _T = new System.Windows.Threading.DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };

            if (WorkShopAction.CheckEllipseLabel_Turn(_CI))
            {
                WorkShopAction.Pause_ForCreate(_T: _T, () => WorkShopAction.EllipseLABEL_TurnOn(_ChangeImageEllipse: _CI));
            }
            else
                WorkShopAction.EllipseLABEL_TurnOff(_ChangeImageEllipse: _CI, _Timer: _T);
        }


    }
}