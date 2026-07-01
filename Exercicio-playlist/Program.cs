using System.Globalization;

namespace Exercicio_playlist;

class Program
{
    static List<string> playlist = new List<string>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Playlist");
            Console.WriteLine("Escolha uma opção: ");
            Console.WriteLine("1 - Adicionar músicas");
            Console.WriteLine("2 - Listar playlist");
            Console.WriteLine("3 - Remover música");
            Console.WriteLine("4 - Buscar música");
            Console.WriteLine("5 - Mostrar quantidade de músicas");
            Console.WriteLine("6 - Tocar música aleatória");
            Console.WriteLine("7 - Limpar playlist");
            Console.WriteLine("0 - Sair");
            if (!int.TryParse(Console.ReadLine(), out int menu))
            {
                Console.WriteLine("Digite uma opção válida!");
                continue;
            }
        
            if (menu == 0) 
            {
                Console.WriteLine("Você escolheu sair. Até mais!");
                break;
            }
            
            switch (menu)
            {
                case 1: AdicionarMusica(); break;
                case 2: ListarMusica(); break;
                case 3: RemoverMusica(); break;
                case 4: BuscarMusica(); break;
                case 5: MostrarQuantidade(); break;
                case 6: TocarAleatoria(); break;
                case 7: LimparPlaylist(); break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        }
    }

    //EXERCICIO PLAYLIST
    
    static void AdicionarMusica()
    {
        Console.WriteLine("Digite o nome do musica para adicionar na playlist: ");
        string nomeMusica = Console.ReadLine();
        playlist.Add(nomeMusica);
    }

    static void ListarMusica()
    {
        Console.WriteLine("Playlist:");
        for (var i = 0; i < playlist.Count; i++) 
        {
            Console.WriteLine($" {i} - {playlist[i]}");
        }
        if (playlist.Count == 0) Console.WriteLine("Nenhuma musica na playlist");
    }

    static void RemoverMusica()
    {
        Console.WriteLine("Digite o nome do musica para remover da playlist: ");
        string nomeMusica = Console.ReadLine();
        if (playlist.Remove(nomeMusica))
        {
            Console.WriteLine("Música removida com sucesso!");
        }
        else
        {
            Console.WriteLine("Música não encontrada na playlist.");
        }
    }

    static void BuscarMusica()
    {
        Console.WriteLine("Digite o nome do musica para buscar na playlist: ");
        string nomeMusica = Console.ReadLine();
        if (playlist.Contains(nomeMusica))
        {
            Console.WriteLine("Música encontrada!");
        }
        else
        {
            Console.WriteLine("Música não encontrada na playlist.");
        }
    }

    static void MostrarQuantidade()
    {
        Console.WriteLine($"Quantidade de músicas na playlist: {playlist.Count}");
    }

    static void TocarAleatoria()
    {
        if (playlist.Count == 0)
        {
            Console.WriteLine("A playlist está vazia, adicione músicas primeiro");
            return;
        }
        Random aleatorio = new Random();
        int indiceAleatorio = aleatorio.Next(playlist.Count);
        string musicaAleatoria = playlist[indiceAleatorio];
        Console.WriteLine($"Tocando agora: {musicaAleatoria}");
    }

    static void LimparPlaylist()
    {
        playlist.Clear();
        Console.WriteLine("Todas as músicas foram removidas da playlist!");
    }
}