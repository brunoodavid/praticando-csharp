using System.Text.RegularExpressions;

public class VerificandoStringNumerica
{
    public static void verificarStringNumerica()
    {
        Console.WriteLine("Digite o  código do cupom: ");

        string codigo = Console.ReadLine()!;

        string regex = @"^\d+$";

        bool ehValido = Regex.IsMatch(codigo, regex);

        if (ehValido)
        {
            Console.WriteLine("O código é valido!");
        }
        else
        {
            Console.WriteLine("O código não é válido!");
        }
    }
}