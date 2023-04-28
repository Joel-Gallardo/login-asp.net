using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        String patron = "InfoToolsSV";
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectar);
            SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar, 50).Value = tbUser.Text;
            cmd.Parameters.Add("@Contrasenia", SqlDbType.VarChar, 50).Value = tbPassword.Text;
            cmd.Parameters.Add("@Patron", SqlDbType.VarChar, 50).Value = patron;
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                //Agregamos una sesion de usuario
                Session["usuariologueado"] = tbUser.Text;
                Response.Redirect("Index.aspx");
            }
            else
            {
                lblError.Text = "La Contraseña ingresada es incorrecta";
            }

            cmd.Connection.Close();
        }
    }
}