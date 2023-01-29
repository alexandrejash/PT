using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Usuarios.Contrato;
using Prueba.Usuarios.Dominio;
using Prueba.Usuarios.Fachada;
namespace Prueba.Usuarios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        public Prueba.Usuarios.Dominio.Usuarios ObtenerUsuario(int IdUsuario)
        {
            using (var instancia = new Prueba.Usuarios.Fachada.UsuarioFachada())
                return instancia.ObtenerUsuario(IdUsuario);
        }

    public IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios()
    {

            using (var instancia = new Prueba.Usuarios.Fachada.UsuarioFachada())
                return instancia.ListarUsuarios();

        }
    }
}
