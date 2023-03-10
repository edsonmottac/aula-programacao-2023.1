

using Exercicio1;

public class Program
{
    public static void Main(string[] args)
    {
        Moto m = new Moto();

        m.Placa = "ABC124";
        m.Marca = "Opala";
        m.Modelo = "XMTO";
        m.Qt_rodas = 2;

        Carro c = new Carro();

        c.Placa = "DEF124";
        c.Marca = "Monza";
        c.Modelo = "ABCD";
        c.Qt_rodas = 4;

        Console.WriteLine($"Placa da Moto: {m.Placa}");
        Console.WriteLine($"Placa do Carro: {c.Placa}");
    }
} 