using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_1
{
    internal class Converter
    {
        private double usd, eur, pln;
        public Converter(double usd, double eur, double pln)
        {
            this.usd = usd;
            this.eur = eur;
            this.pln = pln;
        }

        public void ToUSD(double uahAmount)
        {
            Console.WriteLine(uahAmount / usd);
        }

        public void FromUSD(double uahAmount)
        {
            Console.WriteLine(uahAmount * usd);
        }
        public void ToEUR(double uahAmount)
        {
            Console.WriteLine(uahAmount / eur);
        }

        public void FromEUR(double uahAmount)
        {
            Console.WriteLine(uahAmount * eur);
        }
        public void ToPLN(double uahAmount)
        {
            Console.WriteLine(uahAmount / pln);
        }

        public void FromPLN(double uahAmount)
        {
            Console.WriteLine(uahAmount * pln);
        }
    }
}
