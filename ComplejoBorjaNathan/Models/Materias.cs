using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplejoBorjaNathan.Models
{
    public class Materias
    {
        public int id { get; set; }
        
        public string materia { set; get; }

        public virtual Inscripciones Inscripciones { get; set; }
    }

}