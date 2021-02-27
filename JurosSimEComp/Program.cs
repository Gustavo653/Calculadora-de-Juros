using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JurosSimEComp.Juros;

namespace JurosSimEComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema que calcula juros simples e juros compostos");
            Console.WriteLine();
            Console.WriteLine("ATENÇÃO: O APLICATIVO TRABALHA COM JUROS AO MES, E TEMPO EM MESES!");
            Console.WriteLine("OS JUROS DEVEM SER ESCRITOS DA SEGUINTE FORMA: 2% = 2");
            Console.WriteLine();
            Console.Write("Você deseja calcular juros: (Simples / Compostos) ");
            string strjr = Console.ReadLine();
            if (strjr == "Compostos")
            {
                Console.Write("Insira o capital inicial: ");
                double capital = double.Parse(Console.ReadLine());
                Console.Write("Insira a taxa de juros ao mês: ");
                double taxaDeJuros = double.Parse(Console.ReadLine());
                Console.Write("Insira o tempo em meses: ");
                int tempo = int.Parse(Console.ReadLine());
                JurosCompostos juros = new JurosCompostos(capital, taxaDeJuros, tempo); //Insere as informações no construtor da Classe Juros Simples.
                double CalcularJuros = juros.CalcularJuros(capital, taxaDeJuros, tempo); //Retorna apenas os juros
                double ResultadoJuros = juros.CalcularMontante(capital, taxaDeJuros, tempo); //Retorna o valor total
                Console.WriteLine("Resultados do cálculo: ");
                Console.Write("O valor dos juros foi de: R$" + CalcularJuros.ToString("F2", CultureInfo.InvariantCulture) + " - ");
                Console.Write("O valor do capital é de: R$" + capital.ToString("F2", CultureInfo.InvariantCulture) + " - ");
                Console.Write("O montante total foi de: R$" + ResultadoJuros.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (strjr == "Simples")
            {
                Console.Write("Insira o capital inicial: ");
                double capital = double.Parse(Console.ReadLine());
                Console.Write("Insira a taxa de juros ao mês: ");
                double taxaDeJuros = double.Parse(Console.ReadLine());
                Console.Write("Insira o tempo em meses: ");
                int tempo = int.Parse(Console.ReadLine());
                JurosSimples juros = new JurosSimples(capital, taxaDeJuros, tempo); //Insere as informações no construtor da Classe Juros Simples.
                double CalcularJuros = juros.CalcularJuros(capital, taxaDeJuros, tempo); //Retorna apenas os juros
                double ResultadoJuros = juros.CalcularMontante(capital, taxaDeJuros, tempo); //Retorna o valor total
                Console.WriteLine("Resultados do cálculo: ");
                Console.Write("O valor dos juros foi de: R$" + CalcularJuros.ToString("F2", CultureInfo.InvariantCulture) + " - ");
                Console.Write("O valor do capital é de: R$" + capital.ToString("F2", CultureInfo.InvariantCulture) + " - ");
                Console.Write("O montante total foi de: R$" + ResultadoJuros.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Erro, digite: Simples ou Compostos. Reiniciando programa");
                Main(args);
            }
            Console.ReadKey();
        }
    }
}
