using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Model
{
    public class Garden
    {
        public Garden(decimal cenaZelenchuci, decimal cenaPlodove, int kgZelenchuci, int kgPlodove)
        {
            this.CenaZelenchuci = cenaZelenchuci;
            this.CenaPlodove = cenaPlodove;
            this.KgZelenchuci = kgZelenchuci;
            this.KgPlodove = kgPlodove;
        }

        public decimal CenaZelenchuci { get; set; }
        public decimal CenaPlodove { get; set; }
        public int KgZelenchuci { get; set; }
        public int KgPlodove { get; set; }
        public decimal KalkuliraneNaSuma()
        {
            return (this.KgPlodove * this.CenaPlodove + this.KgZelenchuci * this.CenaZelenchuci)/1.94m;
        }
    }
}
