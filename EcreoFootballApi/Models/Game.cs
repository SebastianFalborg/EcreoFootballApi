namespace EcreoFootballApi.Models;

public class Game
{
    public int Order { get; set; }

    public Team BlueTeam { get; set; }
    
    public int BlueTeamScore { get; set; }

    public Team RedTeam { get; set; }
    
    public int RedTeamScore { get; set; }
}
