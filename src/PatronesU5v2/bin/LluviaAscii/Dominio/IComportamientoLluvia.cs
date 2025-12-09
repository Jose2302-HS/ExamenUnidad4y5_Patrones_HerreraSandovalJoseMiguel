using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    public interface IComportamientoLluvia
    {
        void ActualizarGotas(List<GotaLluvia> gotas, IFabricaGotas fabrica, int ancho, int alto);
    }
}
