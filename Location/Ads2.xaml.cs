using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace Location
{
    public partial class Page2 : PhoneApplicationPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Remove(Location1);
            ContentPanel.Children.Remove(Phone1);
            ContentPanel.Children.Remove(Image1);
            ContentPanel.Children.Remove(Delete1);
            ContentPanel.Children.Remove(DeleteImage1);
            ContentPanel.Children.Remove(Title1);
        }

    }
}