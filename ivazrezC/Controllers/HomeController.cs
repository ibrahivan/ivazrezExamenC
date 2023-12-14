using ivazrezC.Models;
using ivazrezC.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ivazrezC.Controllers
{
    /**
     * Clas HomeController para interactuar con la consola y ver los metodos disponibles
     * author: IvanVazquez
     * RECORDATORIO! BORRAR DATOS DE LA BD PARA VER QUE FUNCIONA LO QUE HAY!!!
      */
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InterfazMenu _menu;
        private readonly InterfazServicios _servicios;

        public HomeController(ILogger<HomeController> logger, InterfazServicios servicio, InterfazMenu menu)
        {
            _logger = logger;
            _menu = menu;
            _servicios = servicio;
        }

        public IActionResult Index()
        {
            VajillaDTO vajDTO = new VajillaDTO();
            bool cerrarMenu = false;
            int opcion;
            do
            {
                _menu.mostrarMenu(); //mostramos menu
                opcion = Console.ReadKey().KeyChar - '0';
                //control de errores
                while (opcion < 0 || opcion > 3)
                {
                    Console.WriteLine("\n\t\t\t**ERROR**");
                    Console.Write("\t\tIntroduce una opcion: ");
                    opcion = Console.ReadKey().KeyChar - '0';
                }
                Console.Clear();
                switch (opcion)
                {

                    case 1:

                        Console.WriteLine("\n\t\t----Alta elemento----");
                        Console.WriteLine("\n\t\t Introduzca el nombre del elemento: ");
                        vajDTO.Nombreelemento=Console.ReadLine();
                        Console.WriteLine("\n\t\t Introduzca la descripcion del elemento:");
                        vajDTO.Descripcionelemento = Console.ReadLine();
                        Console.WriteLine("\n\t\t Introduzca la cantidad del elemento: ");
                        vajDTO.Cantidadelemento = Convert.ToInt32(Console.ReadLine());

                        _servicios.DarAltaElemento(vajDTO);

                        break;
                    case 2:
                        Console.WriteLine("\n\t\t----Mostrar stock----");
                        List<Vajilla> listVaj = new List<Vajilla>();
                        listVaj = _servicios.MostrarStock();

                        foreach (Vajilla vajilla in listVaj)
                        {
                            Console.WriteLine("\t"+vajilla.Codigoelemento+"--"+vajilla.Nombreelemento+"--"+vajilla.Cantidadelemento+"\n");
                        }

                        break;

                    case 3:
                        Console.WriteLine("\n\t\t----Crear reserva----");
                        break;

                    case 0:
                        cerrarMenu = true;
                        break;
                }
                Console.WriteLine("Pulse una tecla para volver al menu");

                Console.ReadKey();

            } while (!cerrarMenu);


            Console.WriteLine("\n\tSaliendo de la aplicacion  \n\tPulse cualquier tecla para cerrar el programa");
            Console.ReadKey();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

       
    
