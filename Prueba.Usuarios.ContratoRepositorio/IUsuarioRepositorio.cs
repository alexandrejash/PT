using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Usuarios.ContratoRepositorio
{
    public interface IUsuarioRepositorio
    {
        Prueba.Usuarios.Dominio.Usuarios ObtenerUsuario(int IdUsuario);

        IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios();

        Prueba.Usuarios.Dominio.Usuarios GestionarUsuario(string accion);
    }
}
