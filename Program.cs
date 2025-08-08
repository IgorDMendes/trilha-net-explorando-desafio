using System.Globalization;
using DesafioProjetoHospedagem.Models;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Cria uma lista e cadastro alguns hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa h1 = new Pessoa(nome: "João", sobrenome: "Silva");
Pessoa h2 = new Pessoa(nome: "Maria", sobrenome: "Oliveira");
Pessoa h3 = new Pessoa(nome: "Pedro", sobrenome: "Santos");
Pessoa h4 = new Pessoa(nome: "Ana", sobrenome: "Souza");
Pessoa h5 = new Pessoa(nome: "Lucas", sobrenome: "Lima");

hospedes.Add(h1);
hospedes.Add(h2);
hospedes.Add(h3);
hospedes.Add(h4);
hospedes.Add(h5);

Suite suite = new Suite(tipo: "Standard", capacidade: 3, valorDiaria: 200m);
Suite suite2 = new Suite(tipo: "Premium", capacidade: 4, valorDiaria: 300m);
Suite suite3 = new Suite(tipo: "Royal", capacidade: 5, valorDiaria: 400m);


// Cria uma nova reserva, passando os dias reservados, a suíte e as datas de entrada e saída
Reserva reserva = new Reserva(diasReservados: 10, suite: suite3, dataEntrada: DateTime.Now, dataSaida: DateTime.Now.AddDays(10));
reserva.CadastrarHospedes(hospedes);


// Exibe a quantidade de hóspedes, data de entrada, data de saída e valor total da reserva
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Data de entrada: {reserva.DataEntrada.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Data de saída: {reserva.DataSaida.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorTotal().ToString("C", CultureInfo.CurrentCulture)}");