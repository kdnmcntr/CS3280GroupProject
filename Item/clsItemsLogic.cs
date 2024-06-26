using GroupProject_Car_Dealership_Prototype.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupProject_Car_Dealership_Prototype.Item
{

    internal class clsItemsLogic
    {
        /// <summary>
        /// Keeps Track of inventory of the store
        /// </summary>
        List<clsItems> inventoryList = new List<clsItems>();

        /// <summary>
        /// Initializes Global Variables
        /// </summary>
        public clsItemsLogic() { 
            //TODO
        }

        /// <summary>
        /// Reterns Array List Of all Items Inside or Invetory. 
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllItems()
        {
            //TODO
            return null;
        }

        /// <summary>
        /// Adds new Item Object In Array List
        /// </summary>
        public void addItem(clsItems item)
        {
            //TODO
            // Posibly have an string returning verifying if item was properly added to array
        }

        /// <summary>
        /// Takes in new instance if clsItems and replaces it with the old 
        /// Instance of clsItems
        /// </summary>
        public void editItem( clsItems oldItem, clsItems newItem)
        {
            //TODO
            // Posibly have an string returning verifying if item was properly edited
        }

        /// <summary>
        /// Takes in coresponding item and removes it from list
        /// </summary>
        public void deleteItem()
        {
            //TODO
            // Posibly have an string returning verifying if item was properly edited
        }

        /// <summary>
        /// Verifies if Item Is in array List.
        /// </summary>
        /// <param name="oldItem"></param>
        private bool isItemInList(clsItems oldItem)
        {
            //TODO
            return false;
        }


        /// <summary>
        /// Gets Items from invenotry adds to list. 
        /// </summary>
        private void addInvetoryToList()
        {
            //TODO
        }

        /// <summary>
        /// updates invetory with new items in the list. 
        /// </summary>
        private void updatesInvetoryToList()
        {
            //TODO
        }
    }
}
