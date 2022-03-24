﻿using System;
using System.Data;
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
using WEBCov19Lib;


    namespace COVID19STAT
    {
        /// <summary>
        /// Логика взаимодействия для MainWindow.xaml
        /// </summary>
        public partial class MainWindow : Window
        {
            public MainWindow()
            {

                InitializeComponent();
                
            

            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataGrid DG = new DataGrid();
            WEBREQ wr = new WEBREQ();
            DataTable DT;
          
            DT = wr.GetStatCOVID19();
            DG.ItemsSource = DT.AsDataView();
        }
    }
    }
