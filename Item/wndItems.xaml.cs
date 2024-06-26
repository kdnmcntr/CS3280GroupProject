using GroupProject_Car_Dealership_Prototype.Main;
using GroupProject_Car_Dealership_Prototype.Search;
using System;
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
using System.Windows.Shapes;

namespace GroupProject_Car_Dealership_Prototype.Item
{
    /// <summary>
    /// Interaction logic for wnditem.xaml
    /// </summary>
    public partial class wndItems : Window
    {  /// <summary>
      /// Initializes Global Variables
      /// </summary>
        public wndItems()
        {
            InitializeComponent();

            // for testing data Grid
        }


        /// <summary>
        /// Handels click for Save Button. It saves item that is being added, removed, or Edited
        /// It verifies that all variables needed for item Object is filled. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        /// <summary>
        /// Handels click for Add Button. Disables Add item, edit item, and delet item button 
        /// Takes in infromation from Item Info box and adds new Item to Item List. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        /// <summary>
        /// Handels click for Edit Button. Button is only inabled if Item is chosen to edit
        /// Takes in infromation from Item Info box and adds edited Item to Item List. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Edit_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }


        /// <summary>
        /// Handels click for Delete Button. Button is only inabled if Item is chosen to delete
        /// removes Item from List. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        /// <summary>
        ///  Handels click for Cancel Button. Enables added, removed, and Edited button
        ///  removes any text inside of the Item from List text boxes. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            //TODO:
        }

        /// <summary>
        /// Handels click for Main Menu Button. Redirects user to main page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void main_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            wndMain main = new wndMain();
            main.Show();
            this.Close();
        }

        /// <summary>
        /// Handels click for Main Menu Button. Redirects user to search page. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void search_Menu_Button_Click(object sender, RoutedEventArgs e)
        {
            wndSearch search = new wndSearch();
            search.Show();
            this.Close();
        }

    
    }
}
