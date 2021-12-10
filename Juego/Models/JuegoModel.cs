using Juego.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Models
{
    public class JuegoModel
    {
        private JugadorModel jugadorAct;

        public JuegoModel(Interface1 Servicio)
        {
            Jugadores = Servicio.CrearJugador();
        }

        public event Action<JugadorModel> Turno;

        public List<JugadorModel> Jugadores { get; private set; }

        public JugadorModel JugadorAct
        {
            get
            {
                return jugadorAct;
            }

            set
            {
                jugadorAct = value;
                Turno(jugadorAct);
            }
        }

        public JugadorModel Oponente
        {
            get
            {
                return Jugadores.Where(p => p != JugadorAct).FirstOrDefault();
            }
        }
    }
}

