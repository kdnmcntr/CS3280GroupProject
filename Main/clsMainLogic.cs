using GroupProject_Car_Dealership_Prototype.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_Car_Dealership_Prototype.Main
{

    internal class clsMainLogic
    {
        private clsInvoice invocie; //posibaly ststic?
        


        /// <summary>
        /// Initializes Global Variables
        /// </summary>
        public clsMainLogic(clsInvoice invocie) {
            this.invocie = invocie;
        }

        /// <summary>
        /// Keeps Track of inventory in invoice
        /// </summary>
        List<clsItems> incoiceList = new List<clsItems>();


        /// <summary>
        /// Reterns Array List Of all Items Inside of Invetory. 
        /// </summary>
        /// <returns></returns>
        public ArrayList getAllItems()
        {
            //TODO
            return null;
        }

        /// <summary>
        /// Adds new Item In Array List from coresponding invoice
        /// </summary>
            public void addItem(clsItems item)
        {
            //TODO
            // Posibly have an string returning verifying if item was properly added to array
        }

        /// <summary>
        /// Takes coresponding item removes it from list
        /// </summary>
        public void removeItem()
        {
            //TODO
            // Posibly have an string returning verifying if item was properly edited
        }

        /// <summary>
        /// think about it relook at video  
        /// </summary>
        public void saveInvoice()
        {
            //TODO
        }
    }
}
