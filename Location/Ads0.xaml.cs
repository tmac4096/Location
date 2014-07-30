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
    public partial class Page3 : PhoneApplicationPage
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ContentPanel.Children.Remove(Location3);
            ContentPanel.Children.Remove(Phone3);
            ContentPanel.Children.Remove(Image3);
            ContentPanel.Children.Remove(Delete3);
            ContentPanel.Children.Remove(DeleteImage3);
            ContentPanel.Children.Remove(Title3);
        }
    }

}