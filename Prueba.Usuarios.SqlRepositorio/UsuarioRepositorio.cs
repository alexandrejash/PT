using Prueba.Usuarios.ContratoRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using Prueba.Usuarios.Dominio;

namespace Prueba.Usuarios.SqlRepositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {


        public Prueba.Usuarios.Dominio.Usuarios ObtenerUsuario(int IdUsuario)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.obtenerCadenaconexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("IdUsuario", IdUsuario);
                var usuario = conexion.QuerySingle<Prueba.Usuarios.Dominio.Usuarios>("dbo.sp_usuario_obtener", param: parametros, commandType: CommandType.StoredProcedure);
                return usuario;
            }
        }
   

        public IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios() 
        {
            using (IDbConnection conexion = new SqlConnection(ConexionRepositorio.obtenerCadenaconexion()))
            {
                var usuarios = conexion.Query<Prueba.Usuarios.Dominio.Usuarios>("dbo.sp_usuario_listar", commandType: CommandType.StoredProcedure);
                return usuarios;
            
            }

               
        }

    }
}
