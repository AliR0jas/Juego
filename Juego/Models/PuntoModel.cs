using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Juego.Models
{
    public class PuntoModel
    {
        public string X { get; set; }

        public int Y { get; set; }

        public Rect Bounds { get; set; }

        public PiezaModel Pieza { get; set; }

        public List<PuntoModel> Datos { get; set; }

        internal bool IsNeighbor(PuntoModel selectedPoint)
        {
            return Datos.Contains(selectedPoint);
        }
    }
}
