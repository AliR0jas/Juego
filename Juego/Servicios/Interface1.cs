using Juego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Servicios
{
    public interface Interface1
    {
        Tuple<List<PuntoModel>, List<List<PuntoModel>>> Crear();

        List<JugadorModel> CrearJugador();
    }
}
