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
            List<ListItem> list = new List<ListItem>();
            ListItem item_coffee = new ListItem();
            item_coffee.Pictrue = new BitmapImage(new Uri("Assets/Cafes.jpg", UriKind.Relative));
            item_coffee.Name = "Cafes";
            list.Add(item_coffee);
            ListItem item_restaurant = new ListItem();
            item_restaurant.Pictrue = new BitmapImage(new Uri("Assets/Restaurants.jpg", UriKind.Relative));
            item_restaurant.Name = "Restaurants";
            list.Add(item_restaurant);
            ListItem item_maket = new ListItem();
            item_maket.Pictrue = new BitmapImage(new Uri("Assets/Makets.jpg", UriKind.Relative));
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
            ListItem s = listbox.SelectedItem as ListItem;

            if (s != null)
            {
                if (listbox.SelectedIndex == 0)
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