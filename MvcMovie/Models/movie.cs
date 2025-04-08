using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class MvcMovie
{
    public int Id { get ; set ;}
    public string? Title { get; set;}
    public DateTime ReleaseDate { get; set;}
    public string? Genre { get; set;}
public decimal Prcie { get; set;}
}

