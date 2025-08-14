public class ClassificandoFaixaEtaria
{
    public static void ClassificarFaixaEtaria()
    {
        int idade = 18;

        if (idade <= 12)
        {
            Console.WriteLine("Infantil");
        }
        else if (idade <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (idade <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Idoso");
        }
    }
}