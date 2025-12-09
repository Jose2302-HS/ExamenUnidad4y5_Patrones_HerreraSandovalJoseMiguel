using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    public class RenderizadorLluvia
    {
        public void InicializarConsola()
        {
            Console.Clear();
        }

        public void DibujarCuadro(List<GotaLluvia> gotas, int ancho, int alto)
        {
            char[,] buffer = new char[alto, ancho];

            for (int fila = 0; fila < alto; fila++)
            {
                for (int col = 0; col < ancho; col++)
                {
                    buffer[fila, col] = ' ';
                }
            }

            foreach (var gota in gotas)
            {
                if (gota.Fila >= 0 && gota.Fila < alto &&
                    gota.Columna >= 0 && gota.Columna < ancho)
                {
                    buffer[gota.Fila, gota.Columna] = gota.Caracter;
                }
            }

            Console.SetCursorPosition(0, 0);
            for (int fila = 0; fila < alto; fila++)
            {
                var linea = new char[ancho];
                for (int col = 0; col < ancho; col++)
                {
                    linea[col] = buffer[fila, col];
                }
                Console.WriteLine(linea);
            }
        }
    }
}
