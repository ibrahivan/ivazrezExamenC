namespace ivazrezC
{
    /**
     * CLASE DTO DE VAJILLA
     */
    public class VajillaDTO
    {
        //atributos con get y set
        public long Idelemento { get; set; }
        public int? Cantidadelemento { get; set; }
        public string Codigoelemento { get; set; } = null!;
        public string? Descripcionelemento { get; set; }
        public string? Nombreelemento { get; set; }
        public long? Idreserva { get; set; }

        //Construcotres
        public VajillaDTO()
        {
        }

        public VajillaDTO(long idelemento, int? cantidadelemento, string codigoelemento, string? descripcionelemento, string? nombreelemento, long? idreserva)
        {
            Idelemento = idelemento;
            Cantidadelemento = cantidadelemento;
            Codigoelemento = codigoelemento;
            Descripcionelemento = descripcionelemento;
            Nombreelemento = nombreelemento;
            Idreserva = idreserva;
        }
    }
}
