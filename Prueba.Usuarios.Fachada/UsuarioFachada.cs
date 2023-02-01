using System;
using System.Collections.Generic;
using Prueba.Usuarios.Dominio;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Usuarios.SqlRepositorio;
using Prueba.Usuarios.ContratoRepositorio;


namespace Prueba.Usuarios.Fachada
{
    public class UsuarioFachada : IDisposable
    {
        public Prueba.Usuarios.Dominio.Usuarios ObtenerUsuario(int IdUsuario)
        {
            IUsuarioRepositorio instancia = new UsuarioRepositorio();
                return instancia.ObtenerUsuario(IdUsuario);
        }

        public IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios()
        {

            IUsuarioRepositorio instancia = new UsuarioRepositorio();          
                return instancia.ListarUsuarios();

        }
        public Prueba.Usuarios.Dominio.Usuarios GestionarUsuario( string accion)
        {
            IUsuarioRepositorio instancia = new UsuarioRepositorio();
            return instancia.GestionarUsuario(accion);
        }


        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
