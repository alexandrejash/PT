using Prueba.Usuarios.ContratoRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Usuarios.SqlRepositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {


        public Prueba.Usuarios.Dominio.Usuarios ObtenerUsuario(int IdUsuario)
        { return null;
        }


        public IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios() 
        {
            return null;
        }

    }
}
