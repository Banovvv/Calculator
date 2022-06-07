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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void buttonClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
        private void buttonClose_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonClose.Opacity = .6; buttonClose.Background = (Brush)new BrushConverter().ConvertFrom("#FF343436");
        }
        private void buttonClose_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonClose.Opacity = .3; buttonClose.Background = (Brush)new BrushConverter().ConvertFrom("#FF242426");
        }
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
