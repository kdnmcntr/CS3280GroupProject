using GroupProject_Car_Dealership_Prototype.Item;
using GroupProject_Car_Dealership_Prototype.Main;
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

namespace GroupProject_Car_Dealership_Prototype.Search
{
    /// <summary>
    /// Interaction logic for wndSearch.xaml
    /// </summary>
    public partial class wndSearch : Window
    {
        public wndSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handels Clear Filer Button. Clears All Combo Boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Clear_Filter_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// Handels select Invoice Button. Sets invoice that will be used in 
        /// other windows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Invoice_Button_Click(object sender, RoutedEventArgs e)
        {

        }


        /// <summary>
        /// Handels click for Main Menu Button. Redirects user to main page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            wndMain main = new wndMain();
           
            Application.Current.MainWindow = main;

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
