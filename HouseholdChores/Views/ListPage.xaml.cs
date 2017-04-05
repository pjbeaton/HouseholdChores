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
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace Household_Chores
{
    public partial class ListPage : PhoneApplicationPage
    {
        // Constructor
        public ListPage()
        {
            InitializeComponent();
        }

        public void AddProject_ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        // When page is navigated to set data context to selected item in list
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            string selectedIndex = "";
            if (NavigationContext.QueryString.TryGetValue("selectedList", out selectedIndex))
            {
                int index = int.Parse(selectedIndex);
                //DataContext = new ListViewModel(
                var test = new Dictionary<int,string>();
                test.Add(1, "Test1");
                test.Add(2, "Test2");
                test.Add(3, "Test3");
                ProjectPicker.ItemsSource = test;
            }
        }
    }
}