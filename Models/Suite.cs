namespace DesafioProjetoHospedagem.Models;


public class Suite
{
    public Suite()
    {
    }

    public Suite(string tipo, int capacidade, decimal valorDiaria)
    {
        Tipo = tipo;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }

    public string Tipo { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDiaria { get; set; }
}