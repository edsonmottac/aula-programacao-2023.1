
using exercicio_pessoa;

public class Program
{
    public static void Main(string[] args)
    {

        Aluno a = new Aluno();
        a.Nome = "jose";
        a.Cpf = "123";
        a.Rg= "123";    
        a.Turma = new Turma{ Codigo="10"};
        a.Matricula = "001";
        a.Semestre = "2";

        a.IncluirALuno();

        Professor p = new Professor();
        p.Nome = "jose";
        p.Cpf = "123";
        p.Rg = "123";
        p.Turma = new Turma { Codigo = "10" };
        p.Matricula = "002";
        p.Admissao = new DateTime(2023, 03, 08);
        p.Salario = 100f;

        p.IncluirProfessor();

    }
}