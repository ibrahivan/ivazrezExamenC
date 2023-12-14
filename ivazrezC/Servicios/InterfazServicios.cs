namespace ivazrezC.Servicios
{
    /**
     * Interfaz de los servicios
     */
    public interface InterfazServicios
    {
        public void DarAltaElemento(VajillaDTO vajDTO);
        public List<Vajilla> MostrarStock();
        public void CrearReserva(PrestamoDTO presDTO);
    }
}
