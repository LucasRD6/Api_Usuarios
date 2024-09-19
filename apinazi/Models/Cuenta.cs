using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace apinazi.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        public string nombre { get; set; }
        [MaxLength(50)]
        public string biografia { get; set; }
        [MaxLength(200)]
        public DateTime fecha_creacion { get; set; }
        public bool musico { get; set; }
        public byte[] foto_Perfil { get; set; }
        public int seguidores { get; set; }
        public int seguidos { get; set; }
        public bool activo { get; set; }
        public bool privado { get; set; }



    }
}
