using ivazrezC;

namespace ivazrezC.Servicios
{
    /**
     * Clase para implementar los servicio crud. HAY QUE BORRAR LOS DATOS DE LA BD PARA COMPROBAR QUE FUNCIONA, QUE NO SE ME HA GENERADO EL SECUENCE
     */
    public class ImplServicios : InterfazServicios
    {
        private readonly exaDosContext _contexto;
        public ImplServicios(exaDosContext dbContext)
        {
            _contexto = dbContext;
        }
        /**
         * Metodo para crear reserva. No me ha dado tiempo
         */
        public void CrearReserva(PrestamoDTO presDTO)
        {
            throw new NotImplementedException();
        }
        /**
         * Metodo para dar de alta un elemento
         * param entr: un objeto vajillaDto
         */
        public void DarAltaElemento(VajillaDTO vajDTO)
        {
            try
            {
                Vajilla vajillaDao = new Vajilla();
                vajillaDao.Nombreelemento = (vajDTO.Nombreelemento);
                vajillaDao.Descripcionelemento = (vajDTO.Descripcionelemento);
                vajillaDao.Cantidadelemento = (vajDTO.Cantidadelemento);
                vajillaDao.Codigoelemento = ("Elem-" + vajDTO.Nombreelemento);

                _contexto.Vajillas.Add(vajillaDao);
                _contexto.SaveChanges();

                Console.WriteLine("\n\tElemento registrado correctamente");
             }catch(Exception e) {

                Console.WriteLine("\n\tElemento no se ha registrado");
             

		    }
}
        /**
        *Metodo para mostrar el stock
        * param salida: lista de objetos Vajilla
        */
        public List<Vajilla> MostrarStock()
        {
            return _contexto.Vajillas.ToList();
        }
    }
}
 


        

