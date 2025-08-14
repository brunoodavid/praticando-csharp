public class ClassificacaoNotaAluno
{
    public static void ClassificarNotaAluno()
    {
        decimal nota = 8.5m;

        if (nota >= 9)
        {
            Console.WriteLine("O aluno recebeu a nota A");
        }
        else if (nota >= 7 && nota < 9)
        {
            Console.WriteLine("O aluno recebeu a nota B");
        }
        else if (nota >= 5 && nota < 7)
        {
            Console.WriteLine("O aluno recebeu a nota C");
        }
        else
        {
            Console.WriteLine("O aluno recebeu a nota D");
        }
    }
}