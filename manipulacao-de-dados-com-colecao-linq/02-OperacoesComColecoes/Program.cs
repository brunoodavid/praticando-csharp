/*
Seja um aplicativo de gerenciamento de músicas onde os usuários podem organizar suas faixas
favoritas em playlists personalizadas. Para cada playlist, é essencial que o usuário tenha
controle total sobre a sequência de reprodução das músicas, permitindo reordená-las
livremente a qualquer momento. Além disso, o aplicativo precisa oferecer a funcionalidade de
reprodução aleatória para uma playlist específica, proporcionando uma experiência de audição
dinâmica e variada, sem, contudo, alterar a ordem original que o usuário definiu. O desafio
é criar uma estrutura robusta que suporte a adição e remoção eficiente de músicas, a
reordenação flexível dentro das playlists e a seleção de faixas tanto em modo sequencial
quanto aleatório.
*/

//Funcoes que vamos implementar:
// [x] Criar as classes para musicas e playlist
// [x] Listar musicas da playlist
// [x] Adicionar musica à playlist
// [x] Obter uma musica especifica da playlist
// [x] Remover musica da playlist
// [x] Tocar uma musica aleatoria da playlist
// [x] Reordenar musicas segundo alguma logica especifica (ex. duracao)
// [x] Uma playlist nao pode ter musicas repetidas
// [x] Exibir as 10 musicas mais tocadas em todas as playlists (ranking)
// [x] Player de musica com:
// [x] - Fila de reproducao (para musicas avulsas e/ou playlists)
// [ ] - Historico de reproducao




using System.Collections;



var musica1 = new Musica { Titulo = "Que Pais é Esse?", Artista = "Legião Urbana", Duracao = 350 };
var musica2 = new Musica { Titulo = "Tempo Perdido", Artista = "Legião Urbana", Duracao = 455 };
var musica3 = new Musica { Titulo = "Pro Dia Nascer Feliz", Artista = "Barão Vermelho", Duracao = 345 };
var musica4 = new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 };
var musica5 = new Musica { Titulo = "Geração Coca-Cola", Artista = "Legião Urbana", Duracao = 380 };

var rockNacional = new Playlist { Nome = "Rock Nacional" };

rockNacional.Add(musica2);
rockNacional.Add(musica1);
rockNacional.Add(musica3);
rockNacional.Add(musica4);
rockNacional.Add(musica5);
rockNacional.Add(new Musica { Titulo = "Eduardo e Mônica", Artista = "Legião Urbana", Duracao = 530 });

var legiaoUrbana = new Playlist { Nome = "Mais populares da legião" };

legiaoUrbana.Add(musica1);
legiaoUrbana.Add(musica2);
legiaoUrbana.Add(musica4);
legiaoUrbana.Add(musica5);

var player = new PlayerDeMusica();
player.AdicionarNaFila(musica1);
player.AdicionarNaFila(rockNacional);


ExibirFila(player);

var proxima = player.ProximaMusicaDaFila();
if (proxima is not null)
{
    Console.WriteLine($"\nTocando a musica {proxima.Titulo}...");
}
else
{
    Console.WriteLine("\nFila de reprodução vazia!");
}

ExibirFila(player);
ExibirHistorico(player);

var anterior = player.MusicaAnterior();
if (anterior is not null)
{
    Console.WriteLine($"\nTocando a musica {anterior?.Titulo}...");
}
else
{
    Console.WriteLine("\nHistórico de reprodução vazia!");
}

ExibirFila(player);
ExibirHistorico(player);

// ExibirPlaylist(rockNacional);
// ExibirPlaylist(legiaoUrbana);
// ExibirMaisTocadas(rockNacional, legiaoUrbana);

// Console.WriteLine("Playlist como foi criada!");
// ExibirPlaylist(rockNacional);

// rockNacional.OrdernarPorDuracao();
// Console.WriteLine("Playlist alterada pela duração.");
// ExibirPlaylist(rockNacional);

// rockNacional.OrdernarPorArtista();
// Console.WriteLine("Playlist alterada por artista.");
// ExibirPlaylist(rockNacional);

// rockNacional.OrdernarPorTitulo();
// Console.WriteLine("Playlist alterada por título.");
// ExibirPlaylist(rockNacional);

void ExibirHistorico(PlayerDeMusica playerDeMusica)
{
    Console.WriteLine("\nExibindo o histórico: ");
    foreach(var musica in playerDeMusica.Historio())
    {
        Console.WriteLine($"\t- {musica.Titulo}");
    }
}

void ExibirFila(PlayerDeMusica player)
{
    Console.WriteLine($"\nExibindo a fila de reprodução:");
    foreach (var musica in player.Fila())
    {
        Console.WriteLine($"\t - {musica.Titulo}");
    }
}

void ExibirMaisTocadas(Playlist playlist1, Playlist playlist2)
{
    Dictionary<Musica, int> ranking = [];

    foreach (var musica in playlist1)
    {
        ranking.Add(musica, 1);
    }

    foreach (var musica in playlist2)
    {
        if (ranking.TryGetValue(musica, out int contagem))
        {
            contagem++;
            ranking[musica] = contagem;
        }
        else
        {
            ranking[musica] = 1;
        }
    }

    List<KeyValuePair<Musica, int>> top = new List<KeyValuePair<Musica, int>>(ranking);

    top.Sort(new PorContagem());
    Console.WriteLine("\nTop 3 músicas mais incluídas nas playlists:");
    int contador = 1;
    foreach (var par in top)
    {
        Console.WriteLine($"\t - {par.Key.Titulo}");
        contador++;
        if (contador > 3) break;
    }
}


void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"Tocando as músicas de {playlist.Nome}");
    foreach (var musica in playlist)
    {
        Console.WriteLine($"\t - {musica.Titulo} ({musica.Artista}) - {musica.Duracao}");
    }
}

void RemoverMusicaPeloTitulo(Playlist playlist, string titulo)
{
    var musicaEncontrada = playlist.ObterPeloTitulo(titulo);
    if (musicaEncontrada is not null)
    {
        Console.WriteLine("Removendo música...");
        playlist.Remove(musicaEncontrada);
    }
    else
    {
        Console.WriteLine("Música não encontrada!");
    }

    ExibirPlaylist(playlist);
}

void ExibirMusicaAleatoria(Playlist playlist)
{
    var musicaAleatoria = playlist.ObterAleatorio();
    if (musicaAleatoria is not null)
    {
        Console.WriteLine($"A música aleatória é: {musicaAleatoria?.Titulo}");
    }
    else
    {
        Console.WriteLine("Playlist vazia");
    }
}

public class PorContagem : IComparer<KeyValuePair<Musica, int>>
{
    public int Compare(KeyValuePair<Musica, int> x, KeyValuePair<Musica, int> y)
    {
        return y.Value.CompareTo(x.Value);
    }
}

public class PorArtista : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        if (x is null) return 1;
        if (y is null) return -1;
        return x.Artista.CompareTo(y.Artista);
    }
}

public class PorTitulo : IComparer<Musica>
{
    public int Compare(Musica? x, Musica? y)
    {
        if (x is null || y is null) return 0;
        // y é maior
        if (x is null) return 1;
        // x é maior
        if (y is null) return -1;
        return x.Titulo.CompareTo(y.Titulo);
    }
}

public class Musica : IComparable
{
    public string? Titulo { get; set; }
    public string? Artista { get; set; }
    public int Duracao { get; set; }

    public int CompareTo(object? obj)
    {
        // iguais: 0 ; menor: -1; maior: 1;
        if (obj is null) return 1;

        Musica outraMusica = obj as Musica;
        return this.Duracao.CompareTo(outraMusica?.Duracao);
    }
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (obj is Musica outraMusica) return this.Titulo.Equals(outraMusica.Titulo) && this.Artista.Equals(outraMusica.Artista);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
    }
}

public class Playlist : ICollection<Musica>
{
    public string? Nome { get; set; }

    public HashSet<Musica> set = [];
    public List<Musica> Lista = [];
    public int Count => Lista.Count;

    public bool IsReadOnly => false;

    public void Add(Musica item)
    {
        if (set.Add(item))
        {
            Lista.Add(item);
        }
    }

    public void Clear()
    {
        Lista.Clear();
    }

    public Musica? ObterPeloTitulo(string titulo)
    {
        foreach (var musica in Lista)
        {
            if (musica.Titulo == titulo)
            {
                return musica;
            }
        }
        return null;
    }

    public Musica? ObterAleatorio()
    {
        if (Lista.Count == 0) return null;

        var random = new Random();
        var numeroAleatorio = random.Next(0, Lista.Count - 1);
        return Lista[numeroAleatorio];
    }

    public void OrdernarPorDuracao()
    {
        Lista.Sort();
    }

    public void OrdernarPorArtista()
    {
        Lista.Sort(new PorArtista());
    }

    public void OrdernarPorTitulo()
    {
        Lista.Sort(new PorTitulo());
    }

    public bool Contains(Musica item)
    {
        return Lista.Contains(item);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        Lista.CopyTo(array, arrayIndex);
    }

    public IEnumerator<Musica> GetEnumerator()
    {
        return Lista.GetEnumerator();
    }

    public bool Remove(Musica item)
    {
        return Lista.Remove(item);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public class PlayerDeMusica
{
    private Queue<Musica> fila = [];       //primeiro a entrar, primeiro a sair (FIFO)
    private Stack<Musica> _pilha = [];     //ultimo a entrar, primeiro a sair   (LIFO)

    public void AdicionarNaFila(Musica musica)
    {
        fila.Enqueue(musica);
    }

    public void AdicionarNaFila(Playlist playlist)
    {
        foreach(var musica in playlist)
        {
            AdicionarNaFila(musica);
        }
    }

    public IEnumerable<Musica> Fila()
    {
        foreach(var musica in fila)
        {
            yield return musica;
        }
    }

    public Musica? ProximaMusicaDaFila()
    {
        if(fila.Count == 0) return null;
        var musica = fila.Dequeue();
        _pilha.Push(musica);    
        return musica;
    }

    public Musica? MusicaAnterior()
    {
        if(_pilha.Count == 0) return null;
        return _pilha.Pop();
    }

    public IEnumerable<Musica> Historio()
    {
        foreach(var musica in _pilha)
            yield return musica;
    }
}