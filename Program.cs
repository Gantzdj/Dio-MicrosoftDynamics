using System.Text;
using MicrosoftDynamics_Dio.Models;

Console.OutputEncoding = Encoding.UTF8;

//Cria os modelos de Hospedes e cadestra na lista de hospedes
List<Pessoa> Hospedes = new();

Pessoa p1 = new(nome: "Hóspede 1");
Pessoa p2 = new(nome: "Hóspede 2");

Hospedes.Add(p1);
Hospedes.Add(p2);

//Criar a Suite
Suite suite = new(tipoSuite: "Premium", capacidade: 2, valorDiaria:30);

//Criar uma nova reserva passando a suite e os hospedes
Reserva reserva = new(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(Hospedes);

//Exibe a quantidade de hospedes e o valor da diária
Console.WriteLine($"Hóspedes:{reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária:{reserva.CalcularValorDiaria()}");