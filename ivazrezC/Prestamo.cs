using System;
using System.Collections.Generic;

namespace ivazrezC
{
    /**
     * Clase Dao de prestamo
     */
    public partial class Prestamo
    {
       

        public long Idreserva { get; set; }
        public DateTime? Fchreserva { get; set; }

        public virtual ICollection<Vajilla> Vajillas { get; set; }

        public Prestamo()
        {
        }

        public Prestamo(long idreserva, DateTime? fchreserva)
        {
            Idreserva = idreserva;
            Fchreserva = fchreserva;
            
        }
    }


}
