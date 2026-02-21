using System.Net.Http.Json;
using BlazorApp3.Models;

namespace BlazorApp3.Services;

public class MoviesService
{
    private readonly HttpClient http;

    public MoviesService(HttpClient http)
    {
        this.http = http;
    }

    public async Task<List<Movie>> GetAll()
    {
        var data = await http.GetFromJsonAsync<List<Movie>>("data/MoviesData.json");
        return data ?? new List<Movie>();
    }
}