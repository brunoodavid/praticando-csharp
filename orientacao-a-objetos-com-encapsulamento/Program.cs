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

// Agenda agenda = new Agenda("Marina Souza");
// agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
// agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
// agenda.AdicionarContato(new Contato("Julia", "21988776655"));
// agenda.ListarContatos();

// Estudante estudante = new Estudante("Lucas Rocha");
// estudante.Nota1 = 4.5;
// estudante.Nota2 = 5.0;

// Console.WriteLine($"Estudante: {estudante.Nome}");
// Console.WriteLine($"Média: {estudante.Media}");
// Console.WriteLine($"Situação: {estudante.Situacao}");

// Curso curso = new Curso("Lógica de Programação", 2);
// curso.Matricular(new EstudanteMatricula("Rafaela"));
// curso.Matricular(new EstudanteMatricula("João"));
// curso.Matricular(new EstudanteMatricula("Mirela")); // excede o limite
// curso.ListarMatriculados();

Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = -250;

Reserva reserva = new Reserva(hospede, quarto, -3);

Console.WriteLine($"Reserva para: {hospede.Nome}");
Console.WriteLine($"Quarto: {quarto.Numero}");
Console.WriteLine($"Valor diaria = {quarto.ValorDiaria}");
Console.WriteLine($"Valor total: {reserva.ValorTotal}");