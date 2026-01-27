//Livro.cadastrarLivros();

//Passagem.EmitirPassagem();

// ContaBancaria conta = new ContaBancaria("123456-7", 1000.00);
// conta.Depositar(500);
// Console.WriteLine(conta.Saldo);

// Funcionario funcionario = new Funcionario("Bruno", "Programador");

// funcionario.mostrarDados();
// funcionario.promover("Programador");
// funcionario.promover("Salgadeiro");
// funcionario.mostrarDados();

// Retangulo retangulo = new Retangulo(5, 8);
// Console.WriteLine($"Area do retangulo = {retangulo.CalcularArea()}");

// Filme filme = new Filme("Matrix", 16);
// filme.ExibirResultado(14);
// filme.ExibirResultado(18);

// Produto caneta = new Produto("Caneta azul", 10);
// caneta.RetirarProdutoEstoque(5);
// caneta.RetirarProdutoEstoque(20);

Pedido pedido1 = new Pedido("001", "Bruno", "Enviado");
pedido1.ExibirPedido();
pedido1.AtualizarPedido("Entregue");
pedido1.ExibirPedido();