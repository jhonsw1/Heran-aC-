using System;

namespace HerançaEprotect
{
    class Program
    {
        static void Main(string[] args)
        {

            //testando com a classe SubBase
            Console.Write("Digite o numero da placa: ");
            string Nplaca = Console.ReadLine();
            Console.Write("Digite o numero do chassi: ");
            string Chassi = Console.ReadLine();
            Console.Write("Digite o numero de portas do veiculo: ");
            int portas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a cor do veiculo: ");
            string cor = Console.ReadLine();
            Automovel documentacao = new Automovel(Nplaca, Chassi, portas, cor);
            Console.WriteLine(documentacao.ToString());
            Console.WriteLine("======================");
            

            //testando com a classe base
            Veiculo testar = new Veiculo();
            Console.Write("Digite o numero da placa: ");
             testar._Placa = Console.ReadLine();
            Console.Write("Digite o numero do chassi: ");
            testar._Chassi = Console.ReadLine();
            Console.Write("Digite o numero de portas do veiculo: ");
            testar.portas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(testar._Placa);
            Console.WriteLine(testar._Chassi);
            Console.WriteLine(testar.portas);

        }
    }
}
