using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplejoBorjaNathan.Models
{
    public class TipoPublicacion
    {
        public int id { get; set; }
        public string tipoPublicacion { get; set; }

        #region crea la relacion uno a uno con Publicaciones
        public List<Publicaciones> Publicaciones { get; set; }
        #endregion

    }
}