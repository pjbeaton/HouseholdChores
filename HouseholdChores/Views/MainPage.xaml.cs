using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Navigation;

namespace Household_Chores
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded +=new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //if (!App.ViewModel.IsDataLoaded)
            //{
            //    App.ViewModel.LoadData();
            //}
            
        }

        private void List_Tapped(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var x = ((TextBlock)sender).Tag;
            //int ID = int.Parse(((TextBlock)sender)Tag.ToString());
            NavigationService.Navigate(new Uri("/Views/ListPage.xaml?selectedList=" + x, UriKind.Relative));
            //MessageBox.Show("You chose list: " + x);
        }
    }
}