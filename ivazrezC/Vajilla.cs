using System;
using System.Collections.Generic;

namespace ivazrezC
{
    /**
     * clase Dao de Vajilla
     */
    public partial class Vajilla
    {
        //Atributos con get y set
        public long Idelemento { get; set; }
        public int? Cantidadelemento { get; set; }
        public string Codigoelemento { get; set; } = null!;
        public string? Descripcionelemento { get; set; }
        public string? Nombreelemento { get; set; }
        public long? Idreserva { get; set; }

        public virtual Prestamo? IdreservaNavigation { get; set; }

        //constructores
        public Vajilla()
        {
        }

        public Vajilla(long idelemento, int? cantidadelemento, string codigoelemento, string? descripcionelemento, string? nombreelemento)
        {
            Idelemento = idelemento;
            Cantidadelemento = cantidadelemento;
            Codigoelemento = codigoelemento;
            Descripcionelemento = descripcionelemento;
            Nombreelemento = nombreelemento;
            
        }
    }
}
