public class ReservaOnline : Reserva
{
    public string NomeReserva { get; set;}

    public ReservaOnline(string nomeReserva)
    {
        this.NomeReserva = nomeReserva;
    }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva online: {NomeReserva}");
        Console.WriteLine($"Link de acesso enviado por email!");
    }
}