using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurosSimEComp.Juros
{
    class JurosSimples
    {
        public double Juros { get; set; }
        public double Capital { get; set; }
        public double TaxaDeJuros { get; set; }
        public int Tempo { get; set; }
        public double MontanteFinal { get; set; }

        public JurosSimples(double capital, double taxaDeJuros, int tempo)
        {
            Capital = capital;
            TaxaDeJuros = taxaDeJuros;
            Tempo = tempo;
        }

        public double CalcularJuros(double capital, double taxaDeJuros, int tempo)
        {
            Juros = (Capital * TaxaDeJuros * Tempo) / 100;
            return Juros;
        }

        public double CalcularMontante(double capital, double taxaDeJuros, int tempo)
        {
            Juros = (Capital * TaxaDeJuros * Tempo) / 100;
            MontanteFinal = Capital + Juros;
            return MontanteFinal;
        }
    }
}
