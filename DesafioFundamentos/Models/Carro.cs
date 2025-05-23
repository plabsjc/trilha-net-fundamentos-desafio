using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioFundamentos.Models
{
    public class Carro
    {
        public Carro(string modelo, string marca, int anoFabricacao, string cor, string placa)
        {
            Modelo = modelo;
            Marca = marca;
            AnoFabricacao = anoFabricacao;
            Cor = cor;
            Placa = placa;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int AnoFabricacao { get; set; }

        public string Cor { get; set; }

        public string Placa { get; set; }

        override public string ToString()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Ano de Fabricação:{AnoFabricacao}, Cor do veículo:{Cor}, Placa:{Placa}";
        }
    }
}