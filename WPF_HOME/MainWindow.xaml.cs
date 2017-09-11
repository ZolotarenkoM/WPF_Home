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
using System.Data.Entity;


namespace WPF_HOME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal Log MyLog = new Log();
        public static string login;
        internal string type;
        internal bool day = false;
        internal bool mounth = false;
        internal DateTime date = DateTime.Now;
        double price;
        List<Product> list = new List<Product>();
        Users user = new Users { User = "mzol", Passwd = "pass"};


        public MainWindow()
        {
            InitializeComponent();
            textBox_Name_product.Text = @"Продукти";
            comboBox_type_things.Text = @"Продукти";
            comboBox_Select_Type.Text = @"Усі витрати";
            dateTimePicker_Select.SelectedDate = DateTime.Today;  


            //dateTime_of_order.SelectedDate = DateTime.Today;    
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
            listView_Item.Items.Remove(listView_Item.SelectedItems[0]);
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
                    price += Convert.ToDouble(textBox_Price_product.Text) * Convert.ToDouble(textBox_Count.Text);
                    textBox_TotalPrice.Text = price.ToString();
                    Product p = new Product();
                    p.Name = textBox_Name_product.Text;
                    p.Price = Convert.ToDouble(textBox_Price_product.Text);
                    p.Count = Convert.ToInt32(textBox_Count.Text);
                    p.TotalPrice = Convert.ToDouble(textBox_Price_product.Text) * Convert.ToDouble(textBox_Count.Text);
                    p.Type = comboBox_type_things.Text;
                    p.Date = Convert.ToDateTime(dateTime_of_order.Text);
                    p.Id.ToString();
                    listView_Item.Items.Add(p);
                    list.Add(p);    // list
                    
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
                textBox_Price_product.Text = @"15";
                textBox_Name_product.Text = comboBox_type_things.Text;
                //CountOfProducts.Text = CountOfProducts.Minimum.ToString();
                textBox_Count.Text = "1";
            }
        }

        //private void comboBox_Select_Type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}

        /// <summary>
        /// Method for select from database product and output to the listView
        /// </summary>
        private void button_Select_Click(object sender, RoutedEventArgs e)
        {
            listView_select.Items.Clear();
            price = 0;
            date = (Convert.ToDateTime(dateTimePicker_Select.SelectedDate));
            type = comboBox_Select_Type.Text;
            day = checkBox_day.IsChecked.GetValueOrDefault();
            mounth = checkBox_Mounth.IsChecked.GetValueOrDefault();
            using (SampleContext db = new SampleContext())
            {
                var product = db.Products_table.OrderBy(pi => pi.Date).ThenBy(pi => pi.Id);
                if (type == "Усі витрати")
                {
                    if (day)
                    {
                        product = db.Products_table.Where(p => p.Date.Day == date.Day).OrderBy(p => p.Date).ThenBy(p => p.Id); // select by Day
                    }
                    else if (mounth)
                    {
                        product = db.Products_table.Where(p => p.Date.Month == date.Month).OrderBy(p => p.Date).ThenBy(p => p.Id);
                    }
                    else { };
                }
                else
                {
                    if (day)
                    {
                        product = db.Products_table.Where(p => p.Date.Day == date.Day & p.Type == type).OrderBy(p => p.Date).ThenBy(p => p.Id); // select by Day
                    }
                    else if (mounth)
                    {
                        product = db.Products_table.Where(p => p.Date.Month == date.Month & p.Type == type).OrderBy(p => p.Date).ThenBy(p => p.Id);
                    }
                    else product = db.Products_table.Where(p => p.Type == type).OrderBy(p => p.Date).ThenBy(p => p.Id); ;
                }
                foreach (var pr in product)
                {
                    listView_select.Items.Add(pr);
                }
                price = (product.Count() != 0) ? product.Sum(p => p.TotalPrice) : 0;
                Total_Price_Select.Text = price.ToString();
            }
            Total_Price_Select.Text = price.ToString("F");       //show total price
        }

        private void button_Reset_Click(object sender, RoutedEventArgs e)
        {
            listView_Item.Items.Clear();
            textBox_TotalPrice.Text = @"0";
            price = 0;
        }

        /// <summary>
        /// Method for insert items from listView to database
        /// </summary>
        private void button_Save_Click(object sender, RoutedEventArgs e)
        {
            using (SampleContext db = new SampleContext())
            {
                db.Users_table.Add(user);
                foreach (var prod in list) db.Products_table.Add(prod);
                db.SaveChanges();
            }
            MessageBox.Show("Saved to db");
        }

        private void button_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void button_Reset_Select_Click(object sender, RoutedEventArgs e)
        {
            listView_select.Items.Clear();
            Total_Price_Select.Text = @"0";
            price = 0;
        }

        /// <summary>
        /// Method for remove selected product from database 
        /// </summary>
        private void button_remove_from_db_Click(object sender, RoutedEventArgs e)
        {
            using (SampleContext db = new SampleContext())
            {
                db.Products_table.Attach((Product)listView_select.SelectedItems[0]);
                db.Products_table.Remove((Product)listView_select.SelectedItems[0]);
                db.SaveChanges();
            }
            MessageBox.Show(@"Rows was deleted!", @"Info");
            button_Select_Click(this, e);
        }

        private void button_clear_table_Click(object sender, RoutedEventArgs e)
        {
            using (SampleContext db = new SampleContext())
            {
                db.Products_table.RemoveRange(db.Products_table);
                db.SaveChanges();
            }
            MessageBox.Show("Reset table successfully");
        }
    }
}
