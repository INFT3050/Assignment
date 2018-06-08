using HMT.WebApp.BLL.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HMT.WebApp.UL
{
    public partial class Admin_ViewTransactions : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();
        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            table = cust.getTransaction();
            placeTable.Controls.Add(new Literal { Text = table.ToString() });
        }
    }
}