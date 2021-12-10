using Juego.Models;
using Juego.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Juego.Controllers
{
    public class RenderController
    {
        private const string siguienteJugador = "Jugador {0}'s mover!";
        

        public event Action<string> NotifyUser;


        public void NuevaP(PuntoModel punto)
        {
            Ellipse ellipse = Crear(punto.Pieza.Color, punto.Bounds);

        }

        public void EliminarPieza(PuntoModel punto)
        {
            Ellipse ellipse = FindEllipseInCanvas(punto);

            if (ellipse == null)
            {
                return;
            }

            ellipse = null;
        }

        public void CambiarSeleccion(PuntoModel punto, bool isSelected)
        {
            Ellipse ellipse = FindEllipseInCanvas(punto);

            if (ellipse == null)
            {
                return;
            }

            var color = isSelected ? Colors.Red : punto.Pieza.Color;
            SolidColorBrush fillBrush = new SolidColorBrush() { Color = color };
            ellipse.Fill = fillBrush;
        }

        private Ellipse FindEllipseInCanvas(PuntoModel punto)
        {
            throw new NotImplementedException();
        }

        public void MoverPieza(PuntoModel puntoAnt, PuntoModel puntoNue)
        {
            Ellipse ellipse = FindEllipseInCanvas(puntoAnt);
            Mover(ellipse, puntoNue.Bounds);
        }

        private Ellipse Crear(Color color, Rect bounds)
        {
            SolidColorBrush fillBrush = new SolidColorBrush() { Color = color };
            SolidColorBrush borderBrush = new SolidColorBrush() { Color = Colors.Black };

            return new Ellipse()
            {
                Height = 50,
                Width = 50,
                Margin = new Thickness(bounds.X, bounds.Y, 50, 50),
                StrokeThickness = 1,
                Stroke = borderBrush,
                Fill = fillBrush
            };
        }

        private void Mover(Ellipse ellipse, Rect newBounds)
        {
            ellipse.Margin = new Thickness(newBounds.X, newBounds.Y, 50, 50);
        }

       
    }
}

