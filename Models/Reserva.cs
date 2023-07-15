using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Threading.Tasks;

namespace MicrosoftDynamics_Dio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite suite { get; set; }
        public int DiasReservados { get; set; }
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //TODO: Verificar se a capacidade é maior ou igual ao número de Hospedes sendo recebido
            //*Implemente aqui*
            if (true)
            {
                Hospedes = hospedes;
            }
            else
            {
            //TODO: Retornar uma exception caso a capacidade for menor que o número de hospedes recebido
            //*Implemente Aqui*
            }
                            
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            //TODO: Retornar a quantidade de hospedes(propriedades)
            //*Implemente Aqui*
            return 0;
        }
        public decimal CalcularValorDiaria()
        {
            //TODO: Retornar o valor da diaria
            //Calculo: DiasReservados x Suites.ValorDiaria
            //*Implemente Aqui*
            decimal valor = 0;

            //Regra: Caso os dias reservados forem maior ou igual  a 10, conceder um desconto de 10%
            //*Implemente Aqui*
            if (true)
            {
                valor = 0;
            }
            
            return valor;
            
        }

    }
}