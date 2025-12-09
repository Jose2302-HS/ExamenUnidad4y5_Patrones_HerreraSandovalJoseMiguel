using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    public class FabricaGotasBasica : IFabricaGotas
    {
        private readonly Random _aleatorio;

        public FabricaGotasBasica()
        {
            _aleatorio = new Random();
        }

        public GotaLluvia CrearGota(int anchoConsola, int altoConsola)
        {
            int columna = _aleatorio.Next(0, Math.Max(1, anchoConsola - 1));
            int filaInicial = 0;
            int velocidad = _aleatorio.Next(1, 3);
            char caracter = '|';

            return new GotaLluvia(columna, filaInicial, velocidad, caracter);
        }
    }
}
