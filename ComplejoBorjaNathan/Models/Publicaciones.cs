using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplejoBorjaNathan.Models
{
    public class Publicaciones
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string titulo { get; set; }

        [Required]
        [StringLength(200)]
        public string descripcion { get; set; }

        [Required]
        
        public string cuerpo { set; get; }

        [Required]
        public string imagenUrl { get; set; }

        [Required]
        public DateTime fecha { set; get; }

        
       public virtual ApplicationUser ApplicationUser { set; get; }

        
        // cre la relacion con tipo de publicacion
        public  TipoPublicacion TipoPublicacion { get; set; }
    }
}