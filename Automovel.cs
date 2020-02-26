using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaEprotect
{
    class Automovel : Veiculo
    {
        public string corVeiculo;
        public Automovel(string Placa, string Chassi, int Portas, string Cor)
        {
            placa = Placa;
            _Chassi = Chassi;
            portas = Portas;
            corVeiculo = Cor;
        }

      
        //Gerando um override para strings dos valores
        public override string ToString()
        {
            return $"Placa: {placa} \n " +
                $"N° chassi: {_Chassi} \n" +
                $"N° Qtd Portas: {Convert.ToString(portas)} \n " +
                $"Cor veiculo: {corVeiculo}";
        }
    }
}
