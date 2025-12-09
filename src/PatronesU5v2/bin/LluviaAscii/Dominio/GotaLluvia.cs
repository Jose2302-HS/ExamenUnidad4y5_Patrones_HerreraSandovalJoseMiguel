using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    public class GotaLluvia
    {
        public int Columna { get; set; }
        public int Fila { get; set; }
        public int Velocidad { get; set; }
        public char Caracter { get; set; }

        public GotaLluvia(int columna, int fila, int velocidad, char caracter)
        {
            Columna = columna;
            Fila = fila;
            Velocidad = velocidad;
            Caracter = caracter;
        }

        public void Avanzar()
        {
            Fila += Velocidad;
        }
    }
}
