using System.Collections.Generic;
using System.Linq;

namespace MedidorModel.DAL
{
    public class UsuariosDALDB : IUsuarioDAL
    {

         private MedidorInteligenteEntities medidorBD = new MedidorInteligenteEntities();
         public void AgregarUsuario(Usuario usuario)
         {
            this.medidorBD.Usuarios.Add(usuario);
            this.medidorBD.SaveChanges();
         }

        public void EliminarUsuario(int id)
        {
             //buscar usuario a eliminar asociado al id  

             Usuario usuario = this.medidorBD.Usuarios.Find(id);
             //destruir el usuario

            this.medidorBD.Usuarios.Remove(usuario);
             this.medidorBD.SaveChanges();
        }

         public Usuario Obtener(int id)
         {
            return this.medidorBD.Usuarios.Find(id);
         }

        public void Actualizar(Usuario u)
        {
            Usuario uOriginal = this.medidorBD.Usuarios.Find(u.Id);
            uOriginal.Nombre = u.Nombre;
            uOriginal.Rut = u.Rut;
            uOriginal.Contraseña = u.Contraseña;
            uOriginal.Correo = u.Correo;

            this.medidorBD.SaveChanges();
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return this.medidorBD.Usuarios.ToList();
        }
    }
}
