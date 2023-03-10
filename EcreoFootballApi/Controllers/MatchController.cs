using EcreoFootballApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcreoFootballApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MatchController : ControllerBase
{
    private readonly ILogger<MatchController> _logger;

    public MatchController(ILogger<MatchController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetMatches")]
    public IEnumerable<Match> Get()
    {
        var teamA = new Team
        {
            Players = new List<Player>
            {
                new()
                {
                    Name = "Jens",
                },
                new()
                {
                    Name = "Sebastian",
                },
                new()
                {
                    Name = "Kent",
                },
            }
        };
        
        var teamB = new Team
        {
            Players = new List<Player>
            {
                new()
                {
                    Name = "Andreas",
                },
                new()
                {
                    Name = "Thomas",
                },
            }
        };

        var match1 = new Match
        {
            Date = DateTime.Parse("10/03/2023 11:45"),
            Games = new List<Game>
            {
                new()
                {
                    Order = 1,
                    BlueTeam = teamB,
                    BlueTeamScore = 10,
                    RedTeam = teamA,
                    RedTeamScore = 7
                },
                new()
                {
                    Order = 2,
                    BlueTeam = teamB,
                    BlueTeamScore = 13,
                    RedTeam = teamA,
                    RedTeamScore = 15
                },
                new()
                {
                    Order = 3,
                    BlueTeam = teamB,
                    BlueTeamScore = 4,
                    RedTeam = teamA,
                    RedTeamScore = 10
                },
            }
        };
        
        var match2 = new Match
        {
            Date = DateTime.Parse("10/03/2023 14:00"),
            Games = new List<Game>
            {
                new()
                {
                    Order = 1,
                    BlueTeam = teamA,
                    BlueTeamScore = 3,
                    RedTeam = teamB,
                    RedTeamScore = 10
                },
                new()
                {
                    Order = 2,
                    BlueTeam = teamA,
                    BlueTeamScore = 10,
                    RedTeam = teamB,
                    RedTeamScore = 4
                },
                new()
                {
                    Order = 3,
                    BlueTeam = teamA,
                    BlueTeamScore = 5,
                    RedTeam = teamB,
                    RedTeamScore = 10
                },
            }
        };

        return new List<Match> { match1, match2 };
    }
}