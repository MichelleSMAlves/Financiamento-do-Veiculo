// Financiamento do veículo (Método com retorno)

using System;

public class FinanciamentoVeiculo
{
    // Método para calcular o financiamento e retornar o valor financiado
    public double CalcularFinanciamento(double precoVeiculo, double entrada, int numParcelas)
    {
        if (precoVeiculo <= 0 || entrada < 0 || numParcelas <= 0)
        {
            throw new ArgumentException("Os valores informados não são válidos.");
        }

        double valorFinanciado = precoVeiculo - entrada;
        double valorParcela = valorFinanciado / numParcelas;

        Console.WriteLine($"Valor financiado: R${valorFinanciado}");
        Console.WriteLine($"Valor da parcela: R${valorParcela}");

        return valorFinanciado;
    }
}

class Program
{
    static void Main(string[] args)
    {
        FinanciamentoVeiculo financiamento = new FinanciamentoVeiculo();

        Console.WriteLine("Digite o preço do veículo:");
        double precoVeiculo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o valor da entrada:");
        double entrada = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o número de parcelas:");
        int numParcelas = Convert.ToInt32(Console.ReadLine());

        try
        {
            double valorFinanciado = financiamento.CalcularFinanciamento(precoVeiculo, entrada, numParcelas);
            Console.WriteLine($"Valor total financiado: R${valorFinanciado}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Por favor, insira valores numéricos válidos.");
        }
    }
}
