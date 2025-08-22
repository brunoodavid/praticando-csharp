public class ClassificacaoNumeros
{
    public static void ClassificarNumeros()
    {
        List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

        foreach (var nota in notas)
        {
            if (nota < 6)
            {
                Console.WriteLine($"Nota {nota} - Reprovado");
            }
            else
            {
                Console.WriteLine($"Nota {nota} - Aprovado");
            }
        }
    }
}