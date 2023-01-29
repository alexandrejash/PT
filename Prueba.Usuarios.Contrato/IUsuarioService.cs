
using System.Collections.Generic;



using System.ServiceModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prueba.Usuarios.Dominio;

namespace Prueba.Usuarios.Contrato
{    // Operaciones del  contrato de servicio   --  

    [ServiceContract]
    public interface IUsuarioService
    {
        //metodos
        [OperationContract]
        Prueba.Usuarios.Dominio.Usuarios  ObtenerUsuario(int IdUsuario);
        [OperationContract]
        IEnumerable<Prueba.Usuarios.Dominio.Usuarios> ListarUsuarios();

    }
}
