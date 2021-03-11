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
    /// Interaction logic for First_Window.xaml
    /// </summary>
    public partial class First_Window : Window
    {
        public First_Window()
        {
            InitializeComponent();
        }
        private void button_ClickP2(object sender, RoutedEventArgs e)
        {
            var p2 = new Second_Window();
            this.Close();
            p2.Show();
        }

        private void END_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}