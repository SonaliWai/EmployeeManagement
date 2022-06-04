using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploayeeManagementServices.Utilities
{
    public static class DbHelper
    {
        public static T GetDataFromDb<T>(this object dataField)
        {
            return dataField == DBNull.Value ? default : (T)dataField;
        }

        public static object GetDataFromUi<T>(this object uiField)
        {
            // If data is null or in case of strings it is blank "", return DBNull

            if (uiField == null ||
                (uiField.GetType() == typeof(string) && (string)uiField == ""))
                return DBNull.Value;

            return (T)uiField;
        }
    }
}
