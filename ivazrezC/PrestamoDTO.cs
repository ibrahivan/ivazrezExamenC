namespace ivazrezC
{
    /*
     * Clase Dto de prestamo
     */
    public class PrestamoDTO
    {
       
        //Atributos con get y set
        public long Idreserva { get; set; }
        public DateTime? Fchreserva { get; set; }

      

        //Constructores
        public PrestamoDTO()
        {
        }

        public PrestamoDTO(long idreserva, DateTime? fchreserva)
        {
            Idreserva = idreserva;
            Fchreserva = fchreserva;
           
        }
    }
}
