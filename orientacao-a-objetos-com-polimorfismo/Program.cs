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

// List<Midia> midias = new List<Midia>
// {
//     new Imagem("paisagem.jpg", "1920x1080"),
//     new Video("filme.mp4", 120)
// };

// foreach (var midia in midias)
// {
//     midia.ExibirDetalhes();
// }

// List<Reserva> reservas = new List<Reserva>
// {
//     new ReservaPresencial("Trilha na serra!"),
//     new ReservaOnline("Workshop de culinária Italiana")
// };

// foreach ( var reserva in reservas)
// {
//     reserva.Confirmar();
// }

// List<Conteudo> conteudos = new List<Conteudo>
// {
//     new AulaGravada("POO na prática", 45),
//     new MaterialComplementar("Resumo do módulo 2", 12)
// };

// foreach(var conteudo in conteudos)
// {
//     conteudo.ExibirInfo();
// }

// List<Transporte> opcoes = new List<Transporte>
// {
//     new Onibus(),
//     new Metro(),
//     new Bicicleta()
// };

// int distancia = 10;

// foreach(var transporte in opcoes)
// {
//     Console.WriteLine($"{transporte.GetType().Name}: {transporte.CalcularTempo(distancia)} min");
// }

// List<IEmprestimo> emprestimos = new List<IEmprestimo>
// {
//     new Estudante(),
//     new Empresario(),
//     new Aposentado()
// };

// foreach(var perfil in emprestimos)
// {
//     decimal total = perfil.CalcularValorFinal(1000m, 12);
//     Console.WriteLine($"{perfil.GetType().Name}: R${total:0.00}");
// }

List<IAcaoBotao> acaoBotoes = new List<IAcaoBotao>
{
    new SalvarAcao(),
    new EditarAcao(),
    new ExcluirAcao()
};

foreach(var botao in acaoBotoes)
{
    botao.Executar();
}