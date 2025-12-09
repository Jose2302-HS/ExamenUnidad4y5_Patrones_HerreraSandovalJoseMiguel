using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    public class ComportamientoLluviaNormal : IComportamientoLluvia
    {
        private readonly Random _aleatorio;

        public ComportamientoLluviaNormal()
        {
            _aleatorio = new Random();
        }

        public void ActualizarGotas(List<GotaLluvia> gotas, IFabricaGotas fabrica, int ancho, int alto)
        {
            for (int i = 0; i < gotas.Count; i++)
            {
                gotas[i].Avanzar();
            }

            for (int i = gotas.Count - 1; i >= 0; i--)
            {
                if (gotas[i].Fila >= alto)
                {
                    gotas.RemoveAt(i);
                }
            }

            int nuevas = _aleatorio.Next(2, 4);
            for (int i = 0; i < nuevas; i++)
            {
                var nuevaGota = fabrica.CrearGota(ancho, alto);
                gotas.Add(nuevaGota);
            }
        }
    }
}
