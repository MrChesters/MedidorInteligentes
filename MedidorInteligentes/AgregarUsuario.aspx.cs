using MedidorModel;
using MedidorModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedidorInteligentes
{
    public partial class AgregarUsuario : System.Web.UI.Page
    {

        private IMedidorDAL medidorDal = new MedidoresDALDB();
        private IUsuarioDAL usuarioDal = new UsuariosDALDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.medidorDDL.DataSource = this.medidorDal.ObtenerMedidor();
                this.medidorDDL.DataTextField = "NombreMedidor";
                this.medidorDDL.DataValueField = "Id";
                this.medidorDDL.DataBind();
            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.Nombre = this.nombreTxt.Text.Trim();
            usuario.Rut = this.rutTxt.Text.Trim();
            usuario.Contraseña = this.contraTxt.Text.Trim();
            usuario.Correo = this.correoTxt.Text.Trim();
            usuario.idMedidor = Convert.ToInt32(this.medidorDDL.SelectedItem.Value);

            this.usuarioDal.AgregarUsuario(usuario);
            Response.Redirect("MostrarUsuario.aspx");
        }
    }
}