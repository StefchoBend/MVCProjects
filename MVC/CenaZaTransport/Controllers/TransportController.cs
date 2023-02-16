using CenaZaTransport.Model;
using CenaZaTransport.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenaZaTransport.Controllers
{
    public class TransportController
    {
         private Transport transport;
         private Display display;
        public TransportController()
        {
            Display display = new Display();
            Transport transport = new Transport(display.Km, display.TimeOfDay);
            display.TotalPrice = transport.CalculatePrice();
            display.ShowResult();
        }
    }
}
