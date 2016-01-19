﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using TripPlanner.Classes;
using System.Globalization;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TripPlanner.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlanDetails : Page
    {
        public PlanDetails()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var plan = (Plans)e.Parameter;
            planDate.Text = "From " + plan.StartDate.Date.ToString("d", DateTimeFormatInfo.InvariantInfo) + " To " + plan.EndDate.Date.ToString("d", DateTimeFormatInfo.InvariantInfo);
            location.Text = "in " + plan.Location;
            testMaxDay.Text = plan.MaxDay.ToString();
            if(plan.MaxDay == 0)
            {
                addNewEvent.IsEnabled = false;
            }
        }
        private void hamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            mySplitView.IsPaneOpen = !mySplitView.IsPaneOpen;
        }

        private void menuItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void editPlanBtn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void deleteEvent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void selectEvent_Click(object sender, RoutedEventArgs e)
        {
            addNewEvent.Visibility = Visibility.Collapsed;
            selectEvent.Visibility = Visibility.Collapsed;
            editEvent.Visibility = Visibility.Visible;
            deleteEvent.Visibility = Visibility.Visible;
            cancelPlan.Visibility = Visibility.Visible;
            addFavorite.Visibility = Visibility.Collapsed;

        }

        private void cancelPlan_Click(object sender, RoutedEventArgs e)
        {
            addNewEvent.Visibility = Visibility.Visible;
            selectEvent.Visibility = Visibility.Visible;
            editEvent.Visibility = Visibility.Collapsed;
            deleteEvent.Visibility = Visibility.Collapsed;
            cancelPlan.Visibility = Visibility.Collapsed;
            addFavorite.Visibility = Visibility.Visible;
        }

        private void addNewEvent_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DayEvents));
        }

        private void addFavorite_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editEvent_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
