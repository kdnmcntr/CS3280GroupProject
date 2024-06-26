using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_Car_Dealership_Prototype.Common
{
 
    class clsItems
    {
     

        /// <summary>
        /// It is a unique code made for item
        /// </summary>
        private string code; //TODO geters an setters

        /// <summary>
        /// It is a discription made for item
        /// </summary>
        private string discription; //TODO geters an setters

        /// <summary>
        /// It is a cost made for item
        /// </summary>
        private double cost; //TODO geters an setters


        /// <summary>
        /// Initializes Global Variables
        /// </summary>
        clsItems(string code, string discription, double cost)
        {
            this.code = code;
           
            this.discription = discription;
            this.cost = cost;
        }

    }
}
