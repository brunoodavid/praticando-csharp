// ClienteVip clienteBruno = new ClienteVip("Bruno", 29, "Diamante", "Vip123");
// Console.WriteLine($"Bem vindo, cliente VIP: {clienteBruno.Nome}");
// Console.WriteLine($"Idade {clienteBruno.Idade}");
// Console.WriteLine($"Nivel Fidelidade: {clienteBruno.NivelFidelidade}");
// Console.WriteLine($"Código VIP: {clienteBruno.CodigoVip}");

// Interno f1 = new Interno("Luciana", "Desenvolvedora", 7000.00);
// Freelancer f2 = new Freelancer("Carlos", "Designer", 3500.00);
// Console.WriteLine($"Funcionario(a): {f1.Nome} - Cargo: {f1.Cargo} - Salário: {f1.Salario} ");
// Console.WriteLine($"Freelancer: {f2.Nome} - Cargo: {f2.Cargo} - Projeto atual: {f2.ValorProjeto} ");

// Passageiro p1 = new Passageiro("Lúcia", 45, 3);
// Passageiro p2 = new Passageiro("Rodrigo", 30, 1);
// p1.ExibirDados();
// p2.ExibirDados();

Analista analista = new Analista("Analista de Sistemas");
Docente docente = new Docente("Docente de Matemática");
Certificado cerf1 = new Certificado(analista);
Certificado certf2 = new Certificado(docente);

Pergaminho pergaminhoAntigo = new Pergaminho("Segredos_Antigos.txt", "A chave para a sabedoria reside na observação...");
pergaminhoAntigo.mostrarDetalhes();
