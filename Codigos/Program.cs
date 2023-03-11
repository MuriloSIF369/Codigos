using FormularioAluno;
using System.ComponentModel.Design;

List<Aluno> FormAluno = new List<Aluno>();
Aluno NovoAluno = new Aluno();
Console.WriteLine("Cadastre o aluno para começar");
CadastrarAluno();
menu:
Console.WriteLine("MENU de opções");
Console.WriteLine("1. Calcular Média.");
Console.WriteLine("2. Calcular Nota Final.");
Console.WriteLine("3. Imprimir Nota Final.");
Console.WriteLine("4. Finalizar menu.");

int option = Convert.ToInt32(Console.ReadLine());

#region Menu
    if(option == 1)
    {
        calcularMedia();
    Console.ReadLine();
    goto menu;
}
    if (option == 2)
    {
        CalcularNotaFinal();
    Console.ReadLine();
    goto menu;
}
    if (option == 3)
    {
        ImprimirNotaFinal();
    Console.ReadLine();
    goto menu;
    }
    else
    {
    }


#endregion

#region Métodos
void CadastrarAluno()
{
    Console.Write("RA do aluno: ");
    NovoAluno.RA = Console.ReadLine();

    Console.Write("Nome do aluno: ");
    NovoAluno.Nome = Console.ReadLine();

    Console.Write("Nota de trabalho: ");
    NovoAluno.NotaTrabalho = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Nota de prova: ");
    NovoAluno.NotaProva = Convert.ToDecimal(Console.ReadLine());

    NovoAluno.NotaFinal = (NovoAluno.NotaProva + NovoAluno.NotaTrabalho) / 2;
}
void calcularMedia()
{
    decimal media = (NovoAluno.NotaTrabalho + NovoAluno.NotaProva) / 2;
    Console.WriteLine($"A média é{media}");
    Console.ReadLine();
}
bool CalcularNotaFinal()
{
    bool resultado;
    if (NovoAluno.NotaFinal >= 7)
    {
        resultado = true;
    }
    else
    {
        resultado = false;
    }
    if (resultado == true)
    {
        Console.Write("Aprovado");
    }
    else
    {
        Console.Write("Reprovado");
    }


    return resultado;
};
void ImprimirNotaFinal()
{
    Console.Write(NovoAluno.NotaFinal);
}
#endregion

