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
    public partial class MostrarUsuario : System.Web.UI.Page
    {
        private IUsuarioDAL usuariosDAL = new UsuariosDALDB();

        
        private void cargarGrilla()
        {
            List<Usuario> usuario;
            usuario = this.usuariosDAL.ObtenerUsuarios();
            this.CargarGrilla(usuario);
        }
        private void CargarGrilla(List<Usuario> usuario)
        {
            this.grillaUsuario.DataSource = usuario;
            this.grillaUsuario.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.CargarGrilla(this.usuariosDAL.ObtenerUsuarios());
            }
        }

        protected void grillaUsuario_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName =="eliminar")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                this.usuariosDAL.EliminarUsuario(id);
                this.cargarGrilla();
            }
        }
    }
}