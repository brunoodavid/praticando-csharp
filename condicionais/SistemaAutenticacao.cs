public class SistemaAutenticacao
{
    public static void AutenticarUsuario()
    {
        Console.WriteLine("Sistema de Autenticação");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Digite seu nome de usuário: ");
        string nomeUsuario = Console.ReadLine()!;

        if (nomeUsuario == "Admin")
        {
            Console.WriteLine("Admin logado");
        }
        else
        {
            Console.WriteLine("Usuario não cadastrado.");
            Console.WriteLine("Opções disponíveis:");
            Console.WriteLine("[1] Cadastrar novo usuário");
            Console.WriteLine("[2] Acessar como convidado");
            Console.WriteLine("[3] Sair");
            int codigo = int.Parse(Console.ReadLine()!);

            switch (codigo)
            {
                case 1:
                    Console.WriteLine($"Novo usuario {nomeUsuario} cadastradao com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("Acesso concedido como convidado.");
                    break;
                case 3:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}