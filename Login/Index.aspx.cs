using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                String usuariologueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = "Welcome " + usuariologueado;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
        protected void BtnCerrar_click(object sender, EventArgs e)
        {
            Session.Remove("usuariologuedo");
            Response.Redirect("Login.aspx");

        }
    }
}