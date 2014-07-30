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
    public partial class Page4 : PhoneApplicationPage
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Remove(Location2);
            ContentPanel.Children.Remove(Phone2);
            ContentPanel.Children.Remove(Image2);
            ContentPanel.Children.Remove(Delete2);
            ContentPanel.Children.Remove(DeleteImage2);
            ContentPanel.Children.Remove(Title2);
        }
    }
}