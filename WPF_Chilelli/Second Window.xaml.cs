using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_Chilelli
{
    /// <summary>
    /// Interaction logic for Second_Window.xaml
    /// </summary>
    public partial class Second_Window : Window
    {
        public Second_Window()
        {
            InitializeComponent();
        }
        private void button_ClickP3(object sender, RoutedEventArgs e)
        {
            var p3 = new Third_Window();
            this.Close();
            p3.Show();
        }

        private void button_ClickP1(object sender, RoutedEventArgs e)
        {
            var p1 = new First_Window();
            this.Close();
            p1.Show();
        }

        private void END_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
