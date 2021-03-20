using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Crear_Registro_Completo_Con_LogIn.Entidades
{
    public class Roles
    {
        [Key]
        public int RolId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public bool esActivo { get; set; }

        public Roles()
        {
            RolId = 0;
            FechaCreacion = DateTime.Now;
            RolesDetalle = new List<RolesDetalle>();
            esActivo = false;
        }

        [ForeignKey("RolId")]
        public virtual List<RolesDetalle> RolesDetalle { get; set; }

    }
}
