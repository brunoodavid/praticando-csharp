public class ReservaPresencial : Reserva
{
    public string NomeReserva {get;set;}

    public ReservaPresencial(string nomeReserva)
    {
        this.NomeReserva = nomeReserva;
    }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva presencial: {NomeReserva}");
        Console.WriteLine($"Ponto de encontro: Praça Central, as 8h");   
    }
}