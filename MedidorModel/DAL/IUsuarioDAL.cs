using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public interface IUsuarioDAL
    {
        List<Usuario> ObtenerUsuarios();

        Usuario Obtener(int id);
        void AgregarUsuario(Usuario usuario);

        void EliminarUsuario(int id);
    }
}
