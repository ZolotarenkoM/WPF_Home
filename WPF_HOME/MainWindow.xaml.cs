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
using Domain;

namespace WPF_HOME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double price;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Program include list of products and things bought by family Zolotarenko\n" +
                            @"author: M.Zolotarenko", @"Information");
        }

        private void button_Select_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Remove_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_add_product_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void comboBox_Select_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Select_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button_Reset_Click(object sender, RoutedEventArgs e)
        {
            listView_Item.Items.Clear();
            textBox_TotalPrice.Text = @"0";
            price = 0;
        }
    }
}
