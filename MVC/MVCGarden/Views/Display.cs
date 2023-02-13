using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Views
{
    public class Display
    {
        public Display()
        {
            this.CenaZelenchuci = 0;
            this.CenaPlodove = 0;
            this.KgZelenchuci = 0;
            this.KgPlodove = 0;
            this.GetValues();
        }
        public decimal CenaZelenchuci { get; set; }
        public decimal CenaPlodove { get; set; }
        public int KgZelenchuci { get; set; }
        public int KgPlodove { get; set; }
        public decimal Rezultat { get; set; }

        public void GetValues()
        {
            this.CenaZelenchuci = decimal.Parse(Console.ReadLine());
            this.CenaPlodove = decimal.Parse(Console.ReadLine());
            this.KgZelenchuci = int.Parse(Console.ReadLine());
            this.KgPlodove = int.Parse(Console.ReadLine());
        }
        public void VijdaneNaRezultat()
        {
            Console.WriteLine(Rezultat);
        }
    }
}
