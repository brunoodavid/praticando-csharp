public class AumentoDeSalario
{
    public static void AumentarSalario()
    {
        decimal salarioAtual = 1500;
        decimal percentual = 10;
        decimal aumentoSalarial = salarioAtual * (percentual / 100);
        decimal novoSalario = salarioAtual + aumentoSalarial;

        Console.WriteLine($"O novo sálario é de R${novoSalario}");

    }
}