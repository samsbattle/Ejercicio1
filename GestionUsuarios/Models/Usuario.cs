using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestionUsuarios.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoMaterno { get; set; }
        public string ApellidoPaterno { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
    }
}