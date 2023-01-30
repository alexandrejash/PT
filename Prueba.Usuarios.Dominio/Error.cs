using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Usuarios.Dominio
{

    [DataContract]
    public class Error
    {
        [DataMember]
            public string codigoError { get; set; }
        [DataMember]
        public string mensajeError { get; set; }
        [DataMember]
        public string  descripcionError { get; set; }
    }
}
