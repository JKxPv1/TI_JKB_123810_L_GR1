namespace BlazorApp3.Models;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string PosterUrl { get; set; }          // Główna ścieżka BlazorApp1/wwwroot/images/posters/x.jpg gdzie x = n+1
    public string ReleaseDate { get; set; } = "";  // np. 32-12-2077 <- bo to string
    public double Rating { get; set; }             // od 0 do 10
    public List<string> Actors { get; set; }       // Tylko imiona kotów 
    public List<string> Categories { get; set; }   // Dozwolone kategorie: Dramat, Komedia, Kryminał, Fantastyka, Horror, Przygodowy, Musical
    public string VideoUrl { get; set; }           // Zawsze "https://www.youtube.com/watch?v=dQw4w9WgXcQ"
    public string Description { get; set; }        // Opis długi
}