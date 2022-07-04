using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using System.Windows;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace moin
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SeleniumHelper helper = new SeleniumHelper();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            helper.Submit();
        }
    }
}
