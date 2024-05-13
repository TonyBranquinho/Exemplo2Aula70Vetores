using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite o numero de produtos");
            int n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            double[] precos = new double[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o nome do produto.");
                nomes[i] = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto.");
                precos[i] = double.Parse(Console.ReadLine(), CI);
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++) {
                soma = soma + precos[i];
            }

            double media = soma / n;
            Console.WriteLine("A media dos preços é de " + media.ToString("F2", CI));

        }
    }
}