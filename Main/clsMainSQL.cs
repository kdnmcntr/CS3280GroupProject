using GroupProject_Car_Dealership_Prototype.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject_Car_Dealership_Prototype.Main
{
    internal class clsMainSQL
    {
        clsDataAccess db;
        DataSet ds;

        public clsMainSQL()
        {
            db = new clsDataAccess();
            ds = new DataSet();
        }

        public DataSet getItems()
        {

            int retVal = 0;

            ds = db.ExecuteSQLStatement("SELECT * FROM Items", ref retVal);
            return ds;
        }

        public void addItem(DataSet itm)
        {
            int retVal = 0;

            db.ExecuteSQLStatement("INSERT INTO Items (CarModel, CarCode, Price) VALUES ({model}, {code}, {price})", ref retVal);
        }

        public void deleteItem(DataSet itm)
        {
            int retVal = 0;

            db.ExecuteSQLStatement("DELETE FROM Items WHERE {code} = CarCode", ref retVal);
        }


    }
}
