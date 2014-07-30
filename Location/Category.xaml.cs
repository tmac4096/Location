using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Windows.Foundation;
using Windows.Foundation.Collections;
using System.Windows.Controls.Primitives;

namespace Location
{
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
            List<SString> list = new List<SString>();
            SString item_coffee = new SString();
            item_coffee.Pictrue = new BitmapImage(new Uri("Assets/thYLFVCRGY.jpg", UriKind.Relative));
            item_coffee.Name = "Cafes";
            list.Add(item_coffee);
            SString item_restaurant = new SString();
            item_restaurant.Pictrue = new BitmapImage(new Uri("Assets/thUEN35U3W.jpg", UriKind.Relative));
            item_restaurant.Name = "Restaurants";
            list.Add(item_restaurant);
            SString item_maket = new SString();
            item_maket.Pictrue = new BitmapImage(new Uri("Assets/th3YSIGUFT.jpg", UriKind.Relative));
            item_maket.Name = "Makets";
            list.Add(item_maket);
            listbox.ItemsSource = list;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Ads.xaml", UriKind.Relative)); 
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox listbox = sender as ListBox;
            SString s = listbox.SelectedItem as SString;

            if (s != null)
            {
                if(listbox.SelectedIndex==0)
                {
                    NavigationService.Navigate(new Uri("/Ads0.xaml", UriKind.Relative)); 
                }
                else if (listbox.SelectedIndex == 1)
                {
                    NavigationService.Navigate(new Uri("/Ads1.xaml", UriKind.Relative));
                }
                else if (listbox.SelectedIndex == 2)
                {
                    NavigationService.Navigate(new Uri("/Ads2.xaml", UriKind.Relative));
                }
            }
            // Clear the selection before we navigate away
            listbox.SelectedItem = null;  
        }
    }
}