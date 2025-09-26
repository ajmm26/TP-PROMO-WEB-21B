using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_PROMO_WEB_21B

{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            button_voucher.Text = "Canjear";

        }

        protected void button_voucher_Click(object sender, EventArgs e)
        {
         
           

        }
    }
}