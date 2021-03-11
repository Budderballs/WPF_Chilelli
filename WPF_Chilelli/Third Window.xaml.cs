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
using System.Windows.Navigation;

namespace WPF_Chilelli
{
    /// <summary>
    /// Interaction logic for Third_Window.xaml
    /// </summary>
    public partial class Third_Window : Window
    {
        public Third_Window()
        {
            InitializeComponent();
        }

        private void button_ClickBackToTwo(object sender, RoutedEventArgs e)
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
