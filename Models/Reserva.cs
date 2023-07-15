using System;
using System.Collections.Generic;

namespace MicrosoftDynamics_Dio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // Verificar se a capacidade é maior ou igual ao número de Hospedes sendo recebido
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Retornar uma exception caso a capacidade for menor que o número de hospedes recebido
                throw new Exception("A capacidade é menor que o número de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retornar a quantidade de hospedes(propriedades)
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            // Retornar o valor da diaria
            // Calculo: DiasReservados x Suite.ValorDiaria
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.1m; // Aplicar desconto de 10%
            }

            return valor;
        }
    }
}
