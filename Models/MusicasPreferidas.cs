using System.Text.Json;
namespace API_music.Models;


internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaDeMusicasPreferidas { get; }

    // Construtor
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasPreferidas = new List<Musica>();
    }

    // Método para adicionar músicas favoritas
    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasPreferidas.Add(musica);
    }

    // Exibindo musicas favoritas
    public void ExibirMusicasFavoritas()
    {
        foreach (var musica in ListaDeMusicasPreferidas)
        {
            Console.WriteLine($"Músicas Favoritas de {Nome}");
            Console.WriteLine($"\n- {musica.Nome} de {musica.Artista}");
        }
    }

    // Gerando arquivos com C# 
    public void GerarArquivoJson()
    {
        // Criando uma string que contenha as informações (Serializando)
        // O "new()" sem tipo, chamamos de objeto anônimo para especificar
        
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome, 
            musica = ListaDeMusicasPreferidas
        });

        // Criando o nome do arquivo
        string nomeArquivo = $"musicas-favoritas-{Nome}.json";

        // Escrevendo o arquivo (Método estático do tipo 'File')
        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine($"Seu arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeArquivo)}");

    }

    // Usando a classe StreamWriter para gerar txt
    public void GerarArquivoTxt()
    {
        string txtArquivo = $"musicas-favorias-{Nome}.txt";

        using(StreamWriter arquivo = new StreamWriter(txtArquivo))
        {
            arquivo.WriteLine($"Musicas favoritas do {Nome}\n");
            foreach (var musica in ListaDeMusicasPreferidas)
            {
                arquivo.WriteLine($"- {musica.Nome}");
            }

        }
        Console.WriteLine($"Txt gerado com sucesso -> {Path.GetFullPath(txtArquivo)}");
    }

}
