public class ConvertendoHorasParaMinuto
{
    public void calcularHorasParMinuto()
    {
        int minutos = 250;
        int horas = minutos / 60;
        int restanteMinutos = minutos % 60;

        Console.WriteLine($"Tempo: {horas} horas e {restanteMinutos} minutos");

    }
}