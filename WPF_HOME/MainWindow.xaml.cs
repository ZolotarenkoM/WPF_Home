using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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
using Session;
using TAlex.WPF.Controls;
//using ControlLib;

namespace WPF_HOME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Log MyLog = new Log();
        public static string login;
        Operation op = new Operation();
        internal string type;
        internal bool day = false;
        internal bool mounth = false;
        internal DateTime date = DateTime.Now;
        double price;
        public MainWindow()
        {
            InitializeComponent();
            textBox_Name_product.Text = @"Продукти";
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
            if (listView_Item.SelectedItems.Count == 0) return;

            //double price_test = (double)((DataRowView)listView_Item.SelectedItems[0])["Price"];
            listView_Item.Items.Remove(listView_Item.SelectedItems[0]);
            //price -= Convert.ToDouble(listView_Item.Items.MoveCurrentToPosition(2));
        }
        

        /// <summary>
        /// Method for Add some product to listView (not database)
        /// </summary>
        private void button_add_product_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBox_Name_product.Text))
                {
                    price += Convert.ToDouble(textBox_Price_product.Text) * Convert.ToDouble(CountOfProducts.Value);
                    textBox_TotalPrice.Text = price.ToString();
                    Product p = new Product();
                    p.Name = textBox_Name_product.Text;
                    p.Price = Convert.ToDouble(textBox_Price_product.Text);
                    p.Count = Convert.ToInt32(CountOfProducts.Value);
                    p.TotalPrice = Convert.ToDouble(textBox_Price_product.Text) * Convert.ToInt32(CountOfProducts.Value);
                    p.Type = comboBox_type_things.Text;
                    p.Date = Convert.ToDateTime(dateTime_of_order.Text);
                    listView_Item.Items.Add(p);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Wrong format");
                MyLog.Write(@"Filing an incorrect format");
            }
            catch (Exception ob)
            {
                MessageBox.Show(ob.Message);
                MyLog.Write(ob.Message);
            }
            finally
            {
                textBox_Price_product.Text = @"0";
                textBox_Name_product.Text = comboBox_type_things.Text;
                CountOfProducts.Text = CountOfProducts.Minimum.ToString();
            }
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
