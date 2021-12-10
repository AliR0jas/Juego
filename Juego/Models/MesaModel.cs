using Juego.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Models
{
    public class MesaModel
    {

        public MesaModel(Interface1 mesaServ)
        {
            var initialBoard = mesaServ.Crear();
            Puntos = initialBoard.Item1;
            Molinos = initialBoard.Item2;
        }

        public List<PuntoModel> Puntos { get; private set; }

        public List<List<PuntoModel>> Molinos { get; private set; }

        public event Action<PuntoModel> NuevaPieza;

        public event Action<PuntoModel> PiezaRem;

        public event Action<PuntoModel, bool> Seleccion;

        public event Action<PuntoModel, PuntoModel> PiezaM;

        public void LugarPieza(PiezaModel pieza, PuntoModel punto)
        {
            punto.Pieza = pieza;
            NuevaPieza(punto);
        }

        public void PiezaEliminada(PuntoModel punto)
        {
            punto.Pieza = null;
            PiezaRem(punto);
        }

        public void CambiarSeleccion(PuntoModel punto, bool isSelected)
        {
            punto.Pieza.IsSelected = isSelected;
            Seleccion(punto, isSelected);
        }

        public void MoverPieza(PuntoModel puntoAnt, PuntoModel PuntoNue)
        {
            PuntoNue.Pieza = puntoAnt.Pieza;
            puntoAnt.Pieza = null;
            PiezaM(puntoAnt, PuntoNue);
        }
    }
}

