// Calculadora calc = new Calculadora();
// Console.WriteLine(calc.Somar(10, 20));
// Console.WriteLine(calc.Somar(5, 10, 15));
// Console.WriteLine(calc.Somar(3.5, 2.8));

// Funcionario f1 = new Gerente();
// Funcionario f2 = new Desenvolvedor();

// Console.WriteLine(f1.GerarRelatorio());
// Console.WriteLine(f2.GerarRelatorio());

// List<INotificacao> notificacoes = new List<INotificacao>
// {
//     new Email(),
//     new Sms(),
//     new Push()
// };

// foreach (var notificacao in notificacoes)
// {
//     notificacao.EnviarMensagem("Sistema fora do ar!");
// }

// List<TarefaAgendada> tarefasAgendadas = new List<TarefaAgendada>
// {
//     new BackupTarefa(),
//     new RelatorioTarefa(),
//     new LimpezaTarefa()
// };

// foreach (var tarefaAgendada in tarefasAgendadas)
// {
//     tarefaAgendada.Executar();
// }

List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("filme.mp4", 120)
};

foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}