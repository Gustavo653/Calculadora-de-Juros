using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JurosSimEComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema que calcula juros simples e juros compostos");
            Console.WriteLine();
            Console.WriteLine("ATENÇÃO: O APLICATIVO TRABALHA COM JUROS AO MES, E TEMPO EM MESES!");
            Console.WriteLine();
            Console.Write("Você deseja calcular juros: (Simples / Compostos) ");
            string strjr = Console.ReadLine();
            strjr.ToLower();
            if (strjr == "compostos")
            {

            }
            else if (strjr == "simples")
            {

            }
            else
            {
                Console.WriteLine("Erro, digite novamente. Reiniciando programa");
                Console.ReadKey();
                Main(args);
            }
        }
    }
}
