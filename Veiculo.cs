using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaEprotect
{
    class Veiculo
    {
        protected string placa;
        private string chassi;
        public int portas;

        //Gerando o metodo getSet para o atributo chassi receber valor fora da classe
        public string _Chassi
        {
            get { return chassi; }
            set
            {
               this.chassi = value;
            }
        }
        //Gerando o metodo getSet para o atributo placa receber valor fora da classe
        public string _Placa
        {
            get { return placa; }
            set
            {
                placa = value;
            }
        }

        //Gerando o metado para string de testes de valores
        public void testar()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"Testando c {chassi}");
            Console.WriteLine($"Testando p {portas}");
            Console.WriteLine($"Testando pl {placa}");
        }
    }
    
}
