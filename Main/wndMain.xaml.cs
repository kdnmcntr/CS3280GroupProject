using GroupProject_Car_Dealership_Prototype.Item;
using GroupProject_Car_Dealership_Prototype.Search;
using System;
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
using System.Windows.Shapes;

namespace GroupProject_Car_Dealership_Prototype.Main
{
    /// <summary>
    /// Interaction logic for wndMain.xaml
    /// </summary>
    public partial class wndMain : Window
    {
        /// <summary>
        /// Initializes Global Variables
        /// </summary>
        public wndMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handels click for Edit Invoice Button Button. It enables 
        /// Ave invoice, add Item ,and Remove Item Button. Makes it Posible for user
        /// to select Item on Data Grid. Alowes User to eddit Invoice. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Invoice_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }


        /// <summary>
        /// Handles click for Add Items Button. It add item 
        /// to corrsponding invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Item_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        /// <summary>
        /// Handles click for Remove Items Button. It removes item 
        /// to corrsponding invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Removes_Item_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        /// <summary>
        /// Handles click for Remove Items Button. saves Changes 
        /// to corrsponding invoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Item_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }


        /// <summary>
        /// Handels click for Search Menu Button. Redirects user to search page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            wndSearch search = new wndSearch();
            search.Show();
            this.Close();
        }


        /// <summary>
        /// Handels click for edit Item Button. Redirects user to editItem page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_Item_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            wndItems wndItems = new wndItems();
            wndItems.Show();
            this.Close();
        }

    }
}
