

using atividade_liskov;

public class Program
{
    public static void Main(string[] args)
    {
        Coordenador coord = new Coordenador();
        coord.Primeiro_nome = "Edson";
        coord.Segundo_nome = "Mota";

        Funcionario func = new Professor();
        //Funcionario f = new Coordenador();
        //Funcionario f = new Diretor();

        func.Primeiro_nome = "Jose";
        func.Segundo_nome = "Souza";
        ((Professor)func).AtribuirSuperior(coord);

        func.calculaSalarioMensal(40);

        Console.WriteLine("\nSalário : " + func.Salario);
        Console.WriteLine("Seu Gerente é : " + func.Gerente?.Primeiro_nome);
    }
}



