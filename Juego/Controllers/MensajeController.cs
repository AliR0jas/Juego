using Juego.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego.Controllers
{
    class MensajeController
    {
        private MesaViewModel mesaViewModel;

        public MensajeController(MesaViewModel mesaViewModel)
        {
            this.mesaViewModel = mesaViewModel;
        }

        public void Usuario(string message)
        {
            //mesaViewModel.Mensaje = message;
        }
    }
}
