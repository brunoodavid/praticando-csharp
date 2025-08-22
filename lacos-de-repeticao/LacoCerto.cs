public class LacoCerto
{
    public static void EscolhendoLacoCerto()
    {
        List<double> notas = new List<double> { 8.5, 6.2, 9.1, 5.8, 7.4 };

        foreach (var nota in notas)
        {
            if (nota < 7)
            {
                Console.WriteLine($"O aluno com a nota {nota} está abaixo da média");
            }
            else
            {
                Console.WriteLine($"O aluno com a nota {nota} está indo muito bem");
            }
        }
    }
}