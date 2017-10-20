using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace ComplejoBorjaNathan.Models
{
    public class Archivos
    {
        public int id { get; set; }
        [Required]
        public string nombreArchivo { set; get; }
        [Required]
        public string urlArchivo { set; get; }
        [Required]
        public DateTime fecha { get; set; }

       
        public Aulas aula { set; get; }
    }
}