


using ExercicioRevisao1;

public class Program
{

    public static void Main(string[] args)
    {
        Carro v =  new Carro();

        v.Placa = "123456";
        v.Marca = "Opala";
        v.Modelo= "XPTO";
        v.Rodas = 2;
       

        Console.WriteLine(v.Marca);
        v.Ligar();
        v.Dirigir();
        v.Desligar();   
        


    
    }

}