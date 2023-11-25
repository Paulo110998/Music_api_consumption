
using API_music.Models;
using System.Linq;


namespace API_music.Filtros
{
    internal class LinqOrder
    {
        // Método que ordena artistas por nomes
        public static void OrdenarArtistas(List<Musica> musics)
        {       
            var artistasOrdenados = musics.OrderBy(musica => 
            musica.Artista).Select(musica => musica.Artista).Distinct()
            .ToList();
            Console.WriteLine("Lista de artistas ordenados:");
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"\n- {artista}");

            }
            
        }
    }
}
