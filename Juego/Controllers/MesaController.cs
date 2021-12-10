using Juego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Controllers
{
    public class MesaController
    {
        MesaModel mesaModel;

        public MesaController(MesaModel mesa)
        {
            mesaModel = mesa;
        }

        public void AgregarPieza(PuntoModel puntoModel, JugadorModel jugador)
        {
            if (puntoModel == null || puntoModel.Pieza != null)
            {
                return;
            }

            var piezaModel = new PiezaModel() { Color = jugador.Color };
            mesaModel.LugarPieza(piezaModel, puntoModel);
        }
        
        public void EliminarPieza(PuntoModel puntoModel)
        {
            if (puntoModel?.Pieza == null)
            {
                return;
            }

            mesaModel.PiezaEliminada(puntoModel);
        }

        public void CambiarSel(PuntoModel nuevoPunto, JugadorModel jugador, bool isSelected)
        {
            if (nuevoPunto.Pieza == null)
            {
                return;
            }

            var puntoAnt = PuntoSelecc();
            if (puntoAnt != null)
            {
                mesaModel.CambiarSeleccion(puntoAnt, false);
            }
            
            mesaModel.CambiarSeleccion(nuevoPunto, isSelected);
        }

        public void MoverPieaza(PuntoModel nuevo)
        {
            var puntoSel = PuntoSelecc();
            if (puntoSel?.Pieza == null || nuevo.Pieza != null || !nuevo.IsNeighbor(puntoSel))
            {
                return;
            }

            mesaModel.MoverPieza(puntoSel, nuevo);
        }

        public PuntoModel PuntoSelecc()
        {
            return mesaModel.Puntos.Where(p => p.Pieza?.IsSelected == true).FirstOrDefault();
        }
    }
}
