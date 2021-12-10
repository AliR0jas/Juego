using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;


namespace Juego.Models
{
    public class JugadorModel
    {
        public JugadorModel(int numero, Color color)
        {
            Numero = numero;
        }
        public int Numero { get; private set; }

        public Color Color { get; private set; }

        public int Total { get; set; }

        public int Piezas { get; set; }

        public bool Milli { get; set; }
    }
}
