using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_de_viagem
{
    public class Viagem
    {
        // variáveis de "entrada"
        private int distancia; // distancia percorrida
        private float consumo; // consumo do veículo
        private float vCombustivel; // valor do consumo de combustivel
        private float vPedagio; // Valor gasto com pedagio

        // variaveis de "saída"
        private float qtdLitros; // qtd. de litros de combustivel usado
        private float vGastoCombustivel; //valor gasto com combustível
        private float vTotal; // valor total da viagem
        private float vKm; // valor por km rodado

        public int Distancia { get => distancia; set => distancia = value; }

        public float Consumo{ get => consumo; set => consumo = value; }

        public float VCombustivel { get => vCombustivel; set => vCombustivel = value; }

        public float VPedagio { get => vPedagio; set => vPedagio = value; }
    }
}
