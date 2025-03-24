using SoundHive.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundHive.Menus
{
    class Pesquisa
    {
        Playlist playlist = new Playlist();

        public void PesquisarPorNome()
        {
            Console.Write("Digite o nome da música que deseja pesquisar: ");
            string nomeMusica = Console.ReadLine()!;
            var musica = playlist.listaDeMusicas.FirstOrDefault(m => m.Nome == nomeMusica);
            if (musica != null)
            {
                Console.WriteLine($"Aqui estão os resultados da pesquisa por [{nomeMusica}] ");

                Console.WriteLine("\n\n=============================================================");
                Console.WriteLine($"========            Música: {musica.Nome}                   ");
                Console.WriteLine($"========            Artista: {musica.Artista}               ");
                Console.WriteLine($"========            Album: {musica.Album}                   ");
                Console.WriteLine($"========            Genero: {musica.Genero}                 ");
                Console.WriteLine("=============================================================");
            }
            else
            {
                Console.WriteLine("Música não encontrada");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }

        public void PesquisarPorArtista() 
        {
            Console.Write("Digite o nome do artista que deseja pesquisar: ");
            string nomeArtista = Console.ReadLine()!;
            var artista = playlist.listaDeMusicas.Where(a => a.Artista == nomeArtista);
            if (artista != null)
            {
                Console.WriteLine("=============================================================");
                Console.WriteLine($"Aqui estão os resultados da pesquisa por [{nomeArtista}] ");
                Console.WriteLine("=============================================================");

                foreach (var item in artista)
                {
                    Console.WriteLine("\n\n=============================================================");
                    Console.WriteLine($"========            Música: {item.Nome}                     ");
                    Console.WriteLine($"========            Artista: {item.Artista}                 ");
                    Console.WriteLine($"========            Album: {item.Album}                     ");
                    Console.WriteLine($"========            Genero: {item.Genero}                   ");
                    Console.WriteLine("=============================================================");
                }
            }
            else
            {
                Console.WriteLine("Artista não encontrado");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }

        public void PesquisarPorAlbum()
        {
            Console.Write("Digite o nome do album que deseja pesquisar: ");
            string nomeAlbum = Console.ReadLine()!;
            var album = playlist.listaDeMusicas.Where(x => x.Album == nomeAlbum);
            if (album != null)
            {
                Console.WriteLine($"Aqui estão os resultados da pesquisa por [{nomeAlbum}] ");

                foreach (var item in album)
                {
                    Console.WriteLine("\n\n=============================================================");
                    Console.WriteLine($"========            Música: {item.Nome}                     ");
                    Console.WriteLine($"========            Artista: {item.Artista}                 ");
                    Console.WriteLine($"========            Album: {item.Album}                     ");
                    Console.WriteLine($"========            Genero: {item.Genero}                   ");
                    Console.WriteLine("=============================================================");
                }
            }
            else
            {
                Console.WriteLine("Album não encontrado");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }

        public void PesquisarPorGenero()
        {
            Console.Write("Digite o nome do genero que deseja pesquisar: ");
            string nomeGenero = Console.ReadLine()!;
            var genero = playlist.listaDeMusicas.Where(g => g.Genero == nomeGenero);
            if (genero != null)
            {
                Console.WriteLine($"Aqui estão os resultados da pesquisa por [{nomeGenero}] ");
                foreach (var item in genero)
                {
                    Console.WriteLine("\n\n=============================================================");
                    Console.WriteLine($"========            Música: {item.Nome}                     ");
                    Console.WriteLine($"========            Artista: {item.Artista}                 ");
                    Console.WriteLine($"========            Album: {item.Album}                     ");
                    Console.WriteLine($"========            Genero: {item.Genero}                   ");
                    Console.WriteLine("=============================================================");
                }
            }
            else
            {
                Console.WriteLine("Genero não encontrado");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal.");
            Console.ReadKey();
        }
    }
}
