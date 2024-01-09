using System.Text.Json;
using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Professor Green");

        //var musicasPreferidasDoMarcinho = new MusicasPreferidas("Marcinho");
        //musicasPreferidasDoMarcinho.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasDoMarcinho.AdicionarMusicasFavoritas(musicas[284]);
        //musicasPreferidasDoMarcinho.AdicionarMusicasFavoritas(musicas[117]);
        //musicasPreferidasDoMarcinho.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidasDoMarcinho.AdicionarMusicasFavoritas(musicas[1462]);
        
        //musicasPreferidasDoMarcinho.ExibirMusicasFavoritas();
        //musicasPreferidasDoMarcinho.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
