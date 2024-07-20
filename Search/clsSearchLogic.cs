using GroupProject_Car_Dealership_Prototype.Common;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Eventing.Reader;
using GroupProject_Car_Dealership_Prototype.Common;
using GroupProject_Car_Dealership_Prototype.Search;
using GroupProject_Prototype.Common;

namespace GroupProject_Car_Dealership_Prototype.Search
{
    public class clsSearchLogic
    {
        clsDataAccess db;
        clsSearchSQL sql;
        DataSet ds;
        private string selectedInvoiceID;
        public string selectedInvoice
        {
            get { return selectedInvoiceID; }
            set { selectedInvoiceID = value; }
        }

        public clsSearchLogic()
        {
            sql = new clsSearchSQL();
            db = new clsDataAccess();
            ds = sql.fillSearchTable();
        }
        public DataSet refineSearch(string date, string charge)
        {
            if (string.IsNullOrEmpty(date))
            {
                return sql.refineFromCharge(charge);
            }
            else if (string.IsNullOrEmpty(charge))
            {
                return sql.refineFromDate(date);
            }
            else
            {
                return sql.refineFromMultiple(date, charge);
            }
        }
    }

}
