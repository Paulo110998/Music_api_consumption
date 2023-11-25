
// Gerenciando a biblioteca HttpClient com o using
using API_music.Models;
using System.Text.Json;
//using API_music.Filtros;


using (HttpClient client = new HttpClient())
{
    try // Try -> Tenta fazer a requisição
    {
        // Buscando os recursos da API pelo endpoint 
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        // Criando uma variável sem tipo que aponta para a lista da classe "Musica"
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[1].ExibirDetalhesDaMusica();

        var minhasMusicasPreferidas = new MusicasPreferidas("Paulo");
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
        minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

        minhasMusicasPreferidas.ExibirMusicasFavoritas();

        minhasMusicasPreferidas.GerarArquivoTxt();
        
    }   
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");            
    }

}





