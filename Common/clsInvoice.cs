using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_Car_Dealership_Prototype.Common
{
  
  
   // List<clsItems>
    
    class clsInvoice
    {

        
        /// <summary>
        /// Keepts Track of invoices unique number
        /// </summary>
        private int invoiceNumber; //setter and getter


        /// <summary>
        /// Date of Invoice 
        /// </summary>
        private DateOnly date; //setter and getter

        /// <summary>
        /// Gets total cost of all items in invoice
        /// </summary>
        private double totalCost;//Getter

        /// <summary>
        /// Keeps Track of inventory in the Invoice
        /// </summary>
        List<clsItems> inventoryInventoryList = new List<clsItems>();

        /// <summary>
        /// Initializes Global Variables
        /// </summary>
        public clsInvoice(int invoiceNumber, DateOnly date, double totalCost, List<clsItems> inventoryInventoryList)
        {
            this.invoiceNumber = invoiceNumber;
            this.date = date;
            this.totalCost = totalCost;
            this.inventoryInventoryList = inventoryInventoryList;
        }
    }
}
