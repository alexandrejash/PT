using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Prueba.Usuarios.Web.Models.Usuarios
{
    public class UsuarioViewModel
    {

        public int IdUsuario { get; set; }

        public string Nombre { get; set; }

        [DisplayFormat(DataFormatString ="{0:dd / MM / yyyy}")]
        public DateTime FechaNacimiento { get; set; }

        public string Sexo { get; set; }
    }
}