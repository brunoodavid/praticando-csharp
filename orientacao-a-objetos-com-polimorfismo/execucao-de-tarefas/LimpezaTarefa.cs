class LimpezaTarefa : TarefaAgendada
{
    public override void Executar()
    {
        Console.WriteLine("Limpando arquivos temporários do servidor...");
    }
}