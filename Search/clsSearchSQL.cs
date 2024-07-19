using GroupProject_Car_Dealership_Prototype.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_Car_Dealership_Prototype.Search
{
    public class clsSearchSQL
    {
        clsDataAccess db;
        DataSet ds;

        public clsSearchSQL()
        {
            db = new clsDataAccess();
            ds = new DataSet();
        }
        public DataSet fillSearchTable()
        {

            int retVal = 0;

            ds = db.ExecuteSQLStatement("Select InvoiceNum, FORMAT([InvoiceDate], 'Short Date'), TotalCost FROM Invoices", ref retVal);
            return ds;
        }

        public DataSet fillNumberCombo()
        {


            int retVal = 0;

            ds = db.ExecuteSQLStatement("SELECT InvoiceNum FROM Invoices", ref retVal);
            return ds;
        }

        public DataSet fillDateCombo()
        {


            int retVal = 0;

            ds = db.ExecuteSQLStatement("SELECT InvoiceDate FROM Invoices", ref retVal);
            return ds;
        }

        public DataSet refineFromInvoiceId(string id)
        {
            int retVal = 0;
            ds = db.ExecuteSQLStatement("SELECT * FROM Invoices WHERE InvoiceNum = " + id, ref retVal);
            return ds;
        }

        public DataSet refineFromDate(string date)
        {
            int retVal = 0;
            ds = db.ExecuteSQLStatement("SELECT * FROM Invoices WHERE InvoiceDate = #" + date + "#", ref retVal);
            return ds;
        }

        public DataSet refineFromCharge(string charge)
        {
            int retVal = 0;
            ds = db.ExecuteSQLStatement("SELECT * FROM Invoices WHERE TotalCost = " + charge, ref retVal);
            return ds;
        }

        public DataSet refineFromMultiple(string date, string charge)
        {
            int retVal = 0;
            ds = db.ExecuteSQLStatement("SELECT * FROM Invoices WHERE InvoiceDate = #" + date + "# OR TotalCost = " + charge, ref retVal);
            return ds;
        }

    }
}
