using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundHive.Menus
{
    class MenuPrincipal
    {
        private Playlist playlist;

        public MenuPrincipal(Playlist playlist)
        {
            this.playlist = playlist;
        }

        public void ExibirMenus()
        {
            int opcao = 0;
            while (opcao != 5)
            {
                Console.Clear();
                Console.WriteLine("===================================");
                Console.WriteLine("           MENU PRINCIPAL          ");
                Console.WriteLine("===================================");
                Console.WriteLine("==   [1] Adicionar uma música    ==");
                Console.WriteLine("==   [2] Listar músicas          ==");
                Console.WriteLine("==   [3] Remover uma música      ==");
                Console.WriteLine("==   [4] Pesquisar na Playlist   ==");
                Console.WriteLine("==   [5] Sair                    ==");

                Console.Write("\nDigite a opção desejada: ");
                opcao = int.Parse(Console.ReadLine()!);


                switch (opcao)
                {
                    case 1:
                        playlist.AdicionarMusica();
                        break;
                    case 2:
                        playlist.ListarMusicas();
                        break;
                    case 3:
                        playlist.RemoverMusica();
                        break;
                    case 4:
                        playlist.PesquisarMusica();
                        break;
                    case 5:
                        Console.WriteLine("Saindo do aplicativo...");
                        Console.WriteLine("Tchau tcahu ;)");
                        playlist.Sair();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

        }
    }
}
