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
        public MainWindow()
        {
            InitializeComponent();
        }
        private void topDrag(object sender, MouseButtonEventArgs e) { DragMove(); }

        private void winLoaded(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
        private void ButtonClose_MouseEnter(object sender, MouseEventArgs e)
        {
            ButtonClose.Opacity = .6; ButtonClose.Background = (Brush)new BrushConverter().ConvertFrom("#3f374c");
        }
        private void ButtonClose_MouseLeave(object sender, MouseEventArgs e)
        {
            ButtonClose.Opacity = .3; ButtonClose.Background = (Brush)new BrushConverter().ConvertFrom("#2f2939");
        }

        string defaultOutputBoxText = "WPF Calculator";

        long num1 = 0;
        long num2 = 0;
        string operation = "";

        List<string> btnDefault = new List<string> { "#2f2939" };
        List<string> btnHover = new List<string> { "#3f374c" };
        List<string> operatorsDefault = new List<string> { "#FF2B2D2E" };
        List<string> operatorsHover = new List<string> { "#FF363A3E" };
        List<string> equalsDefault = new List<string> { "#FF262829" };
        List<string> equalsHover = new List<string> { "#FF2F3030" };

        private void ButtonPlusMinus_MouseEnter(object sender, MouseEventArgs e) { ButtonPlusMinus.Background = (Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void ButtonPlusMinus_MouseLeave(object sender, MouseEventArgs e) { ButtonPlusMinus.Background = (Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void ButtonZero_MouseEnter(object sender, MouseEventArgs e) { ButtonZero.Background = (Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void ButtonZero_MouseLeave(object sender, MouseEventArgs e) { ButtonZero.Background = (Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void ButtonDot_MouseEnter(object sender, MouseEventArgs e) { ButtonDot.Background = (Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void ButtonDot_MouseLeave(object sender, MouseEventArgs e) { ButtonDot.Background = (Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        private void ButtonEquals_MouseEnter(object sender, MouseEventArgs e) { ButtonEquals.Background = (Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        private void ButtonEquals_MouseLeave(object sender, MouseEventArgs e) { ButtonEquals.Background = (Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }
        //private void ButtonOne_MouseEnter(object sender, MouseEventArgs e) { ButtonOne.Background = (Brush)new BrushConverter().ConvertFrom(btnHover[0]); }
        //private void ButtonOne_MouseLeave(object sender, MouseEventArgs e) { ButtonOne.Background = (Brush)new BrushConverter().ConvertFrom(btnDefault[0]); }



        private void ButtonPlusMinus_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10); display.Text = num1.ToString(); clarifier.Text = $"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2 == 0 ? "" : num2.ToString())}"; ;
            }
            else
            {
                num2 = (num2 * 10); display.Text = num2.ToString(); clarifier.Text = num1.ToString() + " " + operation.Replace("*", "×").Replace("/", "÷") + " " + num2.ToString();
            }
        }

        private void ButtonZero_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10); display.Text = num1.ToString(); clarifier.Text = $"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2 == 0 ? "" : num2.ToString())}"; ;
            }
            else
            {
                num2 = (num2 * 10); display.Text = num2.ToString(); clarifier.Text = num1.ToString() + " " + operation.Replace("*", "×").Replace("/", "÷") + " " + num2.ToString();
            }
        }

        private void ButtonDot_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10); display.Text = num1.ToString(); clarifier.Text = $"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2 == 0 ? "" : num2.ToString())}"; ;
            }
            else
            {
                num2 = (num2 * 10); display.Text = num2.ToString(); clarifier.Text = num1.ToString() + " " + operation.Replace("*", "×").Replace("/", "÷") + " " + num2.ToString();
            }
        }
        private void ButtonEquals_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10); display.Text = num1.ToString(); clarifier.Text = $"{num1.ToString()} {operation.Replace("*", "×").Replace("/", "÷")} {(num2 == 0 ? "" : num2.ToString())}"; ;
            }
            else
            {
                num2 = (num2 * 10); display.Text = num2.ToString(); clarifier.Text = num1.ToString() + " " + operation.Replace("*", "×").Replace("/", "÷") + " " + num2.ToString();
            }
        }

    }
}
