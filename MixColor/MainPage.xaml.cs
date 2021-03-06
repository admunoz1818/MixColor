﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MixColor.Resources;
using System.Windows.Media;

namespace MixColor
{
    public partial class MainPage : PhoneApplicationPage
    {
        public bool auxYellow = false;
        public bool auxBlue = false;
        public bool auxRed = false;
        public bool? result;

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        
        private void RadButton1(object sender, RoutedEventArgs e)
        {
            RectangleOne.Fill = new SolidColorBrush(Colors.Blue);
        }

        private void RadButton2(object sender, RoutedEventArgs e)
        {
            RectangleOne.Fill = new SolidColorBrush(Colors.Green);
        }

        private void RadButton3(object sender, RoutedEventArgs e)
        {
            RectangleOne.Fill = new SolidColorBrush(Colors.Orange);
        }

        //Methods and functions of multiple colors

        //function that combines colors
        public void changeColorRectangle()
        {            
            if (auxBlue)
            {
                if (auxBlue)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Blue);
                }
                if (auxBlue && auxRed)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Magenta);
                }
                if (auxBlue && auxYellow)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Green);
                }
                auxYellow = false;
                auxRed = false;
            }
            if (auxYellow)
            {
                if (auxYellow)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Yellow);
                }
                if (auxRed && auxYellow)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Orange);
                }
                if (auxBlue && auxYellow)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Green);
                }
                auxRed = false;
                auxBlue = false;

            }
            if (auxRed)
            {
                if (auxRed)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Red);
                }           
                if (auxRed && auxYellow)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Orange);
                }
                if (auxRed && auxBlue)
                {
                    RectangleSeveral.Fill = new SolidColorBrush(Colors.Magenta);
                }
                auxBlue = false;
                auxYellow = false;
            }
        }
        private void ckbBlue_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)ckbBlue.IsChecked){
                RectangleSeveral.Fill = new SolidColorBrush(Colors.Blue);
                auxBlue = true;
            }
            else{
                auxBlue = false;
            }
            changeColorRectangle();
        }

        private void ckbYellow_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)ckbYellow.IsChecked)
            {
                RectangleSeveral.Fill = new SolidColorBrush(Colors.Yellow);
                auxYellow = true;
            }
            else
            {
                auxYellow = false;
            }
            changeColorRectangle();
        }

        private void ckbRed_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)ckbRed.IsChecked){
                RectangleSeveral.Fill = new SolidColorBrush(Colors.Red);
                auxRed = true;
            }
            else{
                auxRed = false;
            }
            changeColorRectangle();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}