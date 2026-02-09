// Veiculo veiculo = new Veiculo("ABC-1234");
// veiculo.AtualizarVelocidade(72.5);

// Console.WriteLine($"Veículo: {veiculo.Placa}");
// Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual}");

// Avaliacao avaliacao = new Avaliacao("Carla Silva");
// avaliacao.AtribuirNota(11);   // inválido
// avaliacao.AtribuirNota(8.5);  // válido

// Console.WriteLine($"Aluno: {avaliacao.Aluno}");
// Console.WriteLine($"Nota atribuida: {avaliacao.Nota}");

// Paciente paciente = new Paciente("Luiz Costa", 42);
// HistoricoMedico historico = new HistoricoMedico("XPT-9987");
// historico.ExibirCodigo();

// Funcionario f = new Funcionario("Fernanda Lima", 4000);
// f.ReajustarSalario(3500); // Inválido
// f.ReajustarSalario(4200); // Válido

// Console.WriteLine($"Funcionario: {f.Nome}");
// Console.WriteLine($"Salário atual: {f.Salario}");

// Projeto projeto = new Projeto("Sistema de Inventário");
// projeto.AdicionarTarefa("Criar tela de login");
// projeto.AdicionarTarefa("Implementar banco de dados");
// projeto.ExibirTarefas();

// ContaBancaria conta = new ContaBancaria("Carlos Silva", 2500);
// conta.Sacar(1500); // inválido
// conta.Sacar(800);  // válido

// Console.WriteLine($"Saldo atual: R$ {conta.Saldo}");

Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));
agenda.ListarContatos();