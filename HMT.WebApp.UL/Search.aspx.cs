using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HMT.WebApp.BLL.App_Code;
using System.Text;
using HMT.WebApp.DAL.App_Code;

namespace HMT.WebApp.UL
{
    public partial class Search : System.Web.UI.Page
    {
        BuisnessLayer cust = new BuisnessLayer();
        StringBuilder table = new StringBuilder();

        protected void Page_Load(object sender, EventArgs e)
        {
            table = cust.queryProducts(Session["search"].ToString());
            placeTable.Controls.Add(new Literal { Text = table.ToString() });
        }

        protected void searchID_Click(object sender, EventArgs e)
        {

        }
    }
}