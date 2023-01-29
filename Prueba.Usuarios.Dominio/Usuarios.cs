using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Usuarios.Dominio
{
    [DataContract]
    public class Usuarios
    {

        // atributos Nombre Fecha ,sexo
        [DataMember]
        public int IdUsuario { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public DateTime FechaNacimiento { get; set; }
        [DataMember]
        public string Sexo { get; set; }

    }
}
