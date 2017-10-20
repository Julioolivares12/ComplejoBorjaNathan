using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ComplejoBorjaNathan.Models
{
    public class Inscripciones
    {
        public int id { get; set; }
        

       
        public virtual Materias Materias { get; set; }

        
        public ICollection<ApplicationUser> ApliacionUsers { get; set; }
      
        public ICollection<Aulas> Aulas { get; set; }

    }
}