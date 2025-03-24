
namespace SoundHive.Modelos;

public class Musica
{
    
    public string Nome { get; set; }
    public string Artista { get; set; }
    public string Album { get; set; }
    public string Genero { get; set; }


    public override string ToString()
    {
        return $"========================\n" +
                $"Nome: {this.Nome}\n" +
                $"Artista: {this.Artista}\n" +
                $"Album: {this.Album}\n" +
                $"Genero: {this.Genero}\n" +
                $"========================\n";
        }
}
