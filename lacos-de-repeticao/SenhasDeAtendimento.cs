public class SenhasDeAtendimento
{
    public static void GerarSenhas()
    {
        int novaSenha = 0;
        int senhaAtual = 0;
        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("1 - Gerar nova senha");
            Console.WriteLine("2 - Chamar próxima senha");
            Console.WriteLine("3 - Sair");
            opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    novaSenha++;
                    Console.WriteLine($"Senha gerada: {novaSenha.ToString("D3")}");
                    break;
                case 2:
                    senhaAtual++;
                    Console.WriteLine($"Senha chamada: {senhaAtual.ToString("D3")}");
                    break;
                case 3:
                    Console.WriteLine("Encerrando sistema.");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}