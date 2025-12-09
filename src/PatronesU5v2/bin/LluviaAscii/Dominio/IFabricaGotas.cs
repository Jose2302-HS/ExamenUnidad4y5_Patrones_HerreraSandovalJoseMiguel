using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesU5v2
{
    public interface IFabricaGotas
    {
        GotaLluvia CrearGota(int anchoConsola, int altoConsola);
    }
}
