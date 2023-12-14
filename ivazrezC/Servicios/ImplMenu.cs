namespace ivazrezC.Servicios
{
    /**
     * Implementacion del menu
     */
    public class ImplMenu:InterfazMenu
    {
        public void mostrarMenu()
        {
            Console.Write("\n\t\t----Menú----");
            Console.Write("\n\t\t1. Alta elemento");
            Console.Write("\n\t\t2. Mostrar stock");
            Console.Write("\n\t\t3. Crear reserva");
            Console.Write("\n\t\t0. Cerrar app");
        }

       

    }
}
