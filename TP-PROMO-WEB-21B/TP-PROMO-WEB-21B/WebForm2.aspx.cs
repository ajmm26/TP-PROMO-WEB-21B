using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_PROMO_WEB_21B
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             

               for (int i = 1; i <= 10; i++)
               {
                  Panel p = new Panel();
                 p.CssClass = "panel panel-default";
                p.Width = Unit.Pixel(300); // para web Forms se usa Unit
                p.Height = Unit.Pixel(300);
                p.Style.Add("flex", "0 0 auto"); // esto hace que respete ancho y alto
                p.BackColor = System.Drawing.Color.AliceBlue;
                p.BorderStyle = BorderStyle.Solid;
                p.Style.Add("margin", "25px"); // así agregas margen
                contenedor.Controls.Add(p);
            }
        }
    }
}