namespace DesafioProjetoHospedagem.Models;

public class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva()
    {
    }

    public Reserva(int diasReservados, Suite suite, DateTime dataEntrada,
        DateTime dataSaida) // Construtor para inicializar a reserva
    {
        DiasReservados = diasReservados;
        Suite = suite;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;
        Hospedes = new List<Pessoa>();
    }

    public void CadastrarHospedes(List<Pessoa> hospedes) // Método para cadastrar hóspedes
    {
        if (hospedes.Count > Suite.Capacidade)
        {
            throw new Exception("Número de hóspedes excede a capacidade da suíte.");
        }

        if (hospedes.Count < Suite.Capacidade)
        {
            throw new Exception("Número de hóspedes é menor que a capacidade da suíte.");
        }

        Hospedes = hospedes;
    }

    public void CadastrarSuite(string tipoSuite)
    {
        switch (tipoSuite.ToLower())
        {
            case "standard":
                Suite = new Suite { Tipo = "Standard", Capacidade = 3, ValorDiaria = 200m };
                break;
            case "premium":
                Suite = new Suite { Tipo = "Premium", Capacidade = 4, ValorDiaria = 300m };
                break;
            case "royal":
                Suite = new Suite { Tipo = "Royal", Capacidade = 5, ValorDiaria = 400m };
                break;
            default:
                throw new Exception("Tipo de suíte inválido.");
        }
    }

    public decimal CalcularValorTotal()
    {
        if (Suite == null) // Verifica se a suíte foi cadastrada
            throw new Exception("Suite não cadastrada.");

        decimal valor = Suite.ValorDiaria * DiasReservados;
        if (DiasReservados >= 10)
        {
            valor *= 0.9m;
        }
        return valor;
    }

    public int ObterQuantidadeHospedes()
    {
            return Hospedes.Count;
    } 
}
