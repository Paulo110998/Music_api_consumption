using API_music.Models;
using System.Linq;


namespace API_music.Filtros
{
    internal class LinqFilter
    {
        // Criando um método estático para filtrar todos os gêneros musicais
        public static void FiltrarGeneros(List<Musica> musics)
        {
            var todosOsGeneros = musics.Select(genero =>
            genero.Genero).Distinct().ToList();
            foreach (var genero in todosOsGeneros)
            {
                Console.WriteLine($"- {genero}");
            }
        }
        // Filtrando artistas por gêneros musicais
        public static void FiltrarArtistasPorGenero(List<Musica> musics, string genero)
        {
            // Where -> Filtra uma sequência de valores com base em um(a) propriedade/atributo.
            var artistasPorGeneros = musics.Where(musica => 
            musica.Genero!.Contains(genero)).Select(musica =>
            musica.Artista).ToList();
            Console.WriteLine($"Exibindo os artistas do gênero: {genero}");
            foreach (var artista in artistasPorGeneros)
            {
                Console.WriteLine($"- {artista}");


            }
        }
        // Filtrar as músicas de um artista
        public static void FiltrarMusicasPorArtista(List<Musica> musics, string artista)
        {
            // ! -> Não nulo
            var musicasDoArtista = musics.Where(musica => 
            musica.Artista!.Equals(artista)).ToList();
            
            Console.WriteLine($"\nArtista: {artista}");
            foreach (var musica in musicasDoArtista)
            {
                Console.WriteLine($"- {musica.Nome}");

            }

        }
        // Filtrar músicas por ano
        public static void FiltrarMusicasPorAno(List<Musica> musics, int ano)
        {
            var musicasPorAno = musics.Where(musica => musica.Ano == ano)
                .OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome)
                .Distinct().ToList();
            
            Console.WriteLine($"Músicas de {ano}:");
            foreach (var musica in musicasPorAno)
            {
                Console.WriteLine($"- {musica}");


            }
        }

        public static void FiltrarMusicasIndiceUm(List<Musica> musics)
        {
            var musicasIndiceUm = musics.Where(musica_tom => 
            musica_tom.Tonalidade.Equals("C#"))
                .Select(musica_nome => musica_nome.Nome).ToList();
            Console.WriteLine("Músicas em tonalidade C#\n");
            foreach (var musica in musicasIndiceUm)
            {
                Console.WriteLine(musica);


            }
        }
        
    }
}
