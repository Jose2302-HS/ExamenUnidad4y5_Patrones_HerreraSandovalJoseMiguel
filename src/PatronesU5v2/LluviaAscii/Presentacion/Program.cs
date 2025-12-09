using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lluvia ASCII con patrones";
            Console.CursorVisible = false;

            int ancho = Console.WindowWidth;
            int alto = Console.WindowHeight - 1;

            var gotas = new List<GotaLluvia>();

            IFabricaGotas fabrica = new FabricaGotasBasica();
            IComportamientoLluvia comportamiento = new ComportamientoLluviaNormal();
            var renderizador = new RenderizadorLluvia();

            renderizador.InicializarConsola();

            Console.WriteLine("Lluvia ASCII");
            Console.WriteLine("Presiona ESC para salir.");
            Thread.Sleep(1000);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }

                comportamiento.ActualizarGotas(gotas, fabrica, ancho, alto);

                renderizador.DibujarCuadro(gotas, ancho, alto);

                Thread.Sleep(50);
            }

            Console.CursorVisible = true;
        }
    }
}
