using SoundHive.Modelos;

namespace SoundHive.Menus;

class Playlist
{
    Musica musica = new Musica();
    public List<Musica> listaDeMusicas = new List<Musica>()
    {
        new Musica {Nome = "Crazy Train", Artista = "Ozzy Osbourne", Album = "Blizzard of Ozz", Genero = "Rock"},
        new Musica {Nome = "Lose Yourself", Artista = "Eminem", Album = "8 Mile Soundtrack", Genero = "Rap"},
        new Musica {Nome = "Sweet Child O' Mine", Artista = "Guns N' Roses", Album = "Appetite for Destruction", Genero = "Rock"},
        new Musica {Nome = "Juicy", Artista = "The Notorious B.I.G.", Album = "Ready to Die", Genero = "Rap"},
        new Musica {Nome = "Enter Sandman", Artista = "Metallica", Album = "Metallica", Genero = "Rock"},
        new Musica {Nome = "Still D.R.E.", Artista = "Dr. Dre feat. Snoop Dogg", Album = "2001", Genero = "Rap"},
        new Musica {Nome = "Bohemian Rhapsody", Artista = "Queen", Album = "A Night at the Opera", Genero = "Rock"},
        new Musica {Nome = "Changes", Artista = "2Pac", Album = "Greatest Hits", Genero = "Rap"},
        new Musica {Nome = "Smells Like Teen Spirit", Artista = "Nirvana", Album = "Nevermind", Genero = "Rock"},
        new Musica {Nome = "N.Y. State of Mind", Artista = "Nas", Album = "Illmatic", Genero = "Rap"},
        new Musica {Nome = "Hotel California", Artista = "Eagles", Album = "Hotel California", Genero = "Rock"},
        new Musica {Nome = "Sicko Mode", Artista = "Travis Scott", Album = "Astroworld", Genero = "Rap"},
        new Musica {Nome = "Stairway to Heaven", Artista = "Led Zeppelin", Album = "Led Zeppelin IV", Genero = "Rock"},
        new Musica {Nome = "Stronger", Artista = "Kanye West", Album = "Graduation", Genero = "Rap"},
        new Musica {Nome = "Back In Black", Artista = "AC/DC", Album = "Back In Black", Genero = "Rock"},
        new Musica {Nome = "HUMBLE.", Artista = "Kendrick Lamar", Album = "DAMN.", Genero = "Rap"},
        new Musica {Nome = "Paint It Black", Artista = "The Rolling Stones", Album = "Aftermath", Genero = "Rock"},
        new Musica {Nome = "God's Plan", Artista = "Drake", Album = "Scorpion", Genero = "Rap"},
        new Musica {Nome = "Highway to Hell", Artista = "AC/DC", Album = "Highway to Hell", Genero = "Rock"},
        new Musica {Nome = "Rap God", Artista = "Eminem", Album = "The Marshall Mathers LP 2", Genero = "Rap"},
        new Musica {Nome = "Paranoid", Artista = "Black Sabbath", Album = "Paranoid", Genero = "Rock"},
        new Musica {Nome = "No Role Modelz", Artista = "J. Cole", Album = "2014 Forest Hills Drive", Genero = "Rap"},
        new Musica {Nome = "Californication", Artista = "Red Hot Chili Peppers", Album = "Californication", Genero = "Rock"},
        new Musica {Nome = "The Real Slim Shady", Artista = "Eminem", Album = "The Marshall Mathers LP", Genero = "Rap"},
        new Musica {Nome = "Come As You Are", Artista = "Nirvana", Album = "Nevermind", Genero = "Rock"},
        new Musica {Nome = "99 Problems", Artista = "Jay-Z", Album = "The Black Album", Genero = "Rap"},
        new Musica {Nome = "Under the Bridge", Artista = "Red Hot Chili Peppers", Album = "Blood Sugar Sex Magik", Genero = "Rock"},
        new Musica {Nome = "Money Trees", Artista = "Kendrick Lamar feat. Jay Rock", Album = "good kid, m.A.A.d city", Genero = "Rap"},
        new Musica {Nome = "November Rain", Artista = "Guns N' Roses", Album = "Use Your Illusion I", Genero = "Rock"},
        new Musica {Nome = "Stan", Artista = "Eminem feat. Dido", Album = "The Marshall Mathers LP", Genero = "Rap"},
        new Musica {Nome = "Whole Lotta Love", Artista = "Led Zeppelin", Album = "Led Zeppelin II", Genero = "Rock"},
        new Musica {Nome = "In da Club", Artista = "50 Cent", Album = "Get Rich or Die Tryin'", Genero = "Rap"},
        new Musica {Nome = "Seven Nation Army", Artista = "The White Stripes", Album = "Elephant", Genero = "Rock"},
        new Musica {Nome = "Empire State of Mind", Artista = "Jay-Z feat. Alicia Keys", Album = "The Blueprint 3", Genero = "Rap"},
        new Musica {Nome = "Born to Be Wild", Artista = "Steppenwolf", Album = "Steppenwolf", Genero = "Rock"},
        new Musica {Nome = "C.R.E.A.M.", Artista = "Wu-Tang Clan", Album = "Enter the Wu-Tang (36 Chambers)", Genero = "Rap"},
        new Musica {Nome = "My Hero", Artista = "Foo Fighters", Album = "The Colour and the Shape", Genero = "Rock"},
        new Musica {Nome = "All of the Lights", Artista = "Kanye West", Album = "My Beautiful Dark Twisted Fantasy", Genero = "Rap"},
        new Musica {Nome = "Everlong", Artista = "Foo Fighters", Album = "The Colour and the Shape", Genero = "Rock"},
        new Musica {Nome = "Power", Artista = "Kanye West", Album = "My Beautiful Dark Twisted Fantasy", Genero = "Rap"}
    };


    public void AdicionarMusica()
    {

        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           ADICIONAR MÚSICA         ");
        Console.WriteLine("===================================");

        Console.Write("Nome da música: ");
        musica.Nome = Console.ReadLine()!;
        Console.Write("Nome do artista: ");
        musica.Artista = Console.ReadLine()!;
        Console.Write("Nome do album: ");
        musica.Album = Console.ReadLine()!;
        Console.Write("Genero: ");
        musica.Genero = Console.ReadLine()!;
        listaDeMusicas.Add(musica);

        Console.WriteLine("\nMúsica adicionada com sucesso!");

    }

    public void ListarMusicas()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           SUA PLAYLIST            ");
        Console.WriteLine("===================================\n");

        if (listaDeMusicas.Count <= 0) 
        {
            Console.WriteLine("\nSua playlist está vazia");
        }

        foreach (var musica in listaDeMusicas)
        {
            //Console.WriteLine("============================");
            //Console.WriteLine($"Música: {musica.Nome}");
            //Console.WriteLine($"Artista: {musica.Artista}");
            //Console.WriteLine($"Album: {musica.Album}");
            //Console.WriteLine($"Genero: {musica.Genero}");
            //Console.WriteLine("============================");
            Console.WriteLine(musica.ToString());

        }
            Console.WriteLine("\nPressione qualque tecla para voltar ao menu principal");
            Console.ReadKey();

            
    }
    public void RemoverMusica()
    {
        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           REMOVER MÚSICA          ");
        Console.WriteLine("===================================");
        Console.WriteLine("\nQual música deseja remover da playlist? ");
        Console.Write("Música: ");
        string nomeMusica = Console.ReadLine()!;

        var musicaRemovida = listaDeMusicas.FirstOrDefault(m => m.Nome == nomeMusica);

        if (musicaRemovida == null)
        {
            Console.WriteLine($"\nMúsica {nomeMusica} não encontrada na playlist!");
            return;
        }
        listaDeMusicas.Remove(musicaRemovida);

        Console.WriteLine($"\nMúsica {nomeMusica} removida com sucesso!");

        Console.WriteLine("\nPressione qualque tecla para voltar ao menu principal");
        Console.ReadKey();

        

    }

    public void PesquisarMusica()
    {
        Pesquisa pesquisa = new Pesquisa();

        int opcao = 0;

        Console.Clear();
        Console.WriteLine("===================================");
        Console.WriteLine("           PESQUISAR MÚSICA         ");
        Console.WriteLine("===================================");
        Console.WriteLine("==   [1] Por nome da música       ==");
        Console.WriteLine("==   [2] Por nome do artista      ==");
        Console.WriteLine("==   [3] Por nome do álbum        ==");
        Console.WriteLine("==   [4] Por genero               ==");
        Console.WriteLine("==   [5] Voltar ao menu principal ==");

        Console.Write("\nDigite a opção desejada: ");
        opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                pesquisa.PesquisarPorNome();
                break;
            case 2:
                pesquisa.PesquisarPorArtista();
                break;
            case 3:
                pesquisa.PesquisarPorAlbum();
                break;
            case 4:
                pesquisa.PesquisarPorGenero();
                break;
            case 5:
                Console.WriteLine("Deseja voltar ao menu principal? [S/N]");
                string resposta = Console.ReadLine()!;
                if (resposta.ToUpper() == "S")
                {
                    return;
                }
                else
                {
                    PesquisarMusica();
                }
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }

    }

    public void Sair()
    {
        Environment.Exit(0);
    }
}
