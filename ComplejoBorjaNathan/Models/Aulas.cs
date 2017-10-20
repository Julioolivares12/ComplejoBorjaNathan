using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplejoBorjaNathan.Models
{
    public class Aulas
    {
        public int id { get; set; }
        public string nombreAula { get; set; }

        public virtual List<Archivos> archivios { get; set; }
        public virtual Inscripciones Inscripciones { get; set; }
    }
}