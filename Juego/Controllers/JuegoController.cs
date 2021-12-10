using Juego.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Controllers
{
    public class JuegoController
    {
        private JuegoModel juegoModel;

        public JuegoController(JuegoModel juego)
        {
            juegoModel = juego;
        }

        public void Iniciar()
        {
            juegoModel.JugadorAct = juegoModel.Jugadores.First();
        }

        public void Turno()
        {
            juegoModel.JugadorAct.Milli = false;

            if (juegoModel.JugadorAct == juegoModel.Jugadores[0])
            {
                juegoModel.JugadorAct = juegoModel.Jugadores[1];
            }
            else
            {
                juegoModel.JugadorAct = juegoModel.Jugadores[0];
            }
        }

        public void Contador(PuntoModel punto)
        {
            juegoModel.JugadorAct.Total++;
            juegoModel.JugadorAct.Total++;
        }

        public void PiezasOponente(PuntoModel point)
        {
            juegoModel.Oponente.Total--;
        }
    }
}
