using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurosSimEComp.Juros
{
    class JurosCompostos
    {
        public double Juros { get; set; }
        public double Capital { get; set; }
        public double TaxaDeJuros { get; set; }
        public int Tempo { get; set; }
        public double MontanteFinal { get; set; }

        public JurosCompostos(double capital, double taxaDeJuros, int tempo)
        {
            Capital = capital;
            TaxaDeJuros = taxaDeJuros;
            Tempo = tempo;
        }

        public double CalcularJuros(double capital, double taxaDeJuros, int tempo)
        {
            MontanteFinal = (Capital * Math.Pow(1 + taxaDeJuros, tempo)) / 1000000;
            double juros = MontanteFinal - Capital;
            return juros;
        }

        public double CalcularMontante(double capital, double taxaDeJuros, int tempo)
        {
            taxaDeJuros += 1;
            MontanteFinal = (Capital * Math.Pow(taxaDeJuros, tempo)) / 1000000;
            return MontanteFinal;
        }
    }
}
