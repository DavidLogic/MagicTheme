using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MagicTheme.ViewModels;
namespace MagicTheme
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WPFUI.Background.Manager.Apply(this);
            InitializeComponent();
            IntPtr windowHandle = new WindowInteropHelper(this).Handle;
            WPFUI.Background.Manager.Apply(WPFUI.Background.BackgroundType.Mica, windowHandle);
            WPFUI.Theme.Manager.SetSystemTheme();
            WPFUI.Theme.Manager.IsSystemThemeCompatible();
            var mainWindowViewModel = new MainWindowViewModel();
            mainWindowViewModel.CurrentTheme = WPFUI.Theme.Manager.CurrentTheme.ToString(); 
        }

    }
}
