using System.Text;
using Desafio.Models;

List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede 1");
Pessoa p2 = new Pessoa(nome: "Hospede 2");

hospedes.Add(p1);
hospedes.Add(p2);

Suite suite = new Suite(tipoSuite: "Premium", capacidade: 5, valorDiaria: 100);

Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastraSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"Hospedes: {reserva.ObeterQuantidadeHospedes()}");
Console.WriteLine($"Valor diaria: {reserva.CalcularValorDiaria()}");