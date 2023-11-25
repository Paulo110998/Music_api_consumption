using System.Text.Json.Serialization;

namespace API_music.Models;

internal class Got
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }

    [JsonPropertyName("culture")]
    public string? Cultura { get; set; }

    [JsonPropertyName("born")]
    public string? Nascimento { get; set; }

    [JsonPropertyName("titles")]
    public List<string>? Titulo { get; set; }

    public void DetalhesPersonagens()
    {
        Console.WriteLine("Detalhes dos Personagens:");
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Cultura: {Cultura}");
        Console.WriteLine($"Nascido em: {Nascimento}");
        Console.Write($"Título: ");
        foreach (string titulo in Titulo)
        {
            Console.WriteLine($"{titulo}");

        }
    }
}
