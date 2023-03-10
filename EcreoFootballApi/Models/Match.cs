namespace EcreoFootballApi.Models;

public class Match
{
    public IEnumerable<Game> Games { get; set; }

    public DateTime Date { get; set; }
}

