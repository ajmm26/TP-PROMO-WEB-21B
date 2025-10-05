using dominio;
using negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP_PROMO_WEB_21B
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            btnCanjear.Text = "Canjear";

        }


        protected void btnCanjear_Click1(object sender, EventArgs e)
        {
            string value = input_voucher.Text.Trim();

            if (value == "" || value == null || value == " ")
            {     // Texto rojo
                txtlabelError.BorderColor = System.Drawing.Color.Red;
                txtlabelError.BackColor = System.Drawing.Color.LightPink; // Fondo
                mensaje("Ingrese un Voucher", System.Drawing.Color.Red);
            }
            else
            {



                txtlabelError.Visible = false;
                if (vouchersCodigo(value))
                {
                    Session.Add("voucher", value);
                    Response.Redirect("WebForm2.aspx", true);
                }
            }

        }


        protected bool vouchersCodigo(string value)
        {
            negocioVoucher negocio = new negocioVoucher();
            List<Voucher> vouchers = negocio.listar();

            foreach (Voucher voucher in vouchers)
            {

                if (voucher.Codigo.ToUpper().Trim() == value.ToUpper())
                {
                    if (voucher.IdCliente != 0)
                    {
                        txtlabelError.BorderColor = System.Drawing.Color.Red;
                        txtlabelError.BackColor = System.Drawing.Color.LightPink; // Fondo
                        mensaje("Voucher usado", System.Drawing.Color.Red);
                    }
                    else
                    {
                        txtlabelError.BorderColor = System.Drawing.Color.Green;
                        txtlabelError.BackColor = System.Drawing.Color.LightGreen; // Fondo
                        mensaje("Voucher  valido", System.Drawing.Color.Black);
                        return true;
                    }
                }
                else
                {
                    if (voucher.Codigo.ToUpper().Trim() != value.ToUpper())
                    {
                        txtlabelError.BorderColor = System.Drawing.Color.Red;
                        txtlabelError.BackColor = System.Drawing.Color.LightPink; // Fondo
                        mensaje("Voucher invalido", System.Drawing.Color.Red);

                    }
                }

            }
            return false;
        }



        protected void mensaje(string m, System.Drawing.Color color)
        {
            txtlabelError.BorderStyle = BorderStyle.Solid;
            txtlabelError.BorderWidth = 2;
            txtlabelError.Width = 350;
            txtlabelError.ForeColor = color;   // <-- color dinámico
            txtlabelError.Text = m;
            txtlabelError.Visible = true;

        }


    }
}