using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace EmploayeeManagementServices.Utilities
{
    public static class HtmlHelper
    {
        public static string GetFormattedValue(this string text)
        {
            return text.Replace("\n", "<br />\n");
        }

        public static void ShowStatusMessage(this Label label, string message)
        {
            label.Text = message;
            label.Visible = true;
        }

    }
}
