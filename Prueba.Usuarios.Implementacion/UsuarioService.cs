using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prueba.Usuarios.Contrato;
using Prueba.Usuarios.Dominio;
using Prueba.Usuarios.Fachada;
using System.ServiceModel;
namespace Prueba.Usuarios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        public Prueba.Usuarios.Dominio.Usuarios ObtenerUsuario(int IdUsuario)
        {

            try
            {


                using (var instancia = new Prueba.Usuarios.Fachada.UsuarioFachada())
                    return instancia.ObtenerUsuario(IdUsuario);
            }
            catch (Exception)
            {
                // verificar -- 
                throw new FaultException<Error>(new Error() { codigoError = "1", descripcionError = " Servicio", mensajeError = "222" });
            }
       
           
        }

    public IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios()
    {

            using (var instancia = new Prueba.Usuarios.Fachada.UsuarioFachada())
                return instancia.ListarUsuarios();

        }
    }
}
