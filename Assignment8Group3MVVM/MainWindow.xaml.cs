﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment8Group3MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WorldSeriesWinner wsn;
        public MainWindow()
        {
            InitializeComponent();
            wsn = new WorldSeriesWinner();
            DataContext = wsn;
        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            wsn.GetResult();
        }
    }
}
