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
                    Name = "Rasmus",
                },
            }
        };
        
        var teamB = new Team
        {
            Players = new List<Player>
            {
                new()
                {
                    Name = "Sebastian",
                },
                new()
                {
                    Name = "Gorm",
                },
            }
        };

        var match1 = new Match
        {
            Date = DateTime.Now.AddDays(-1),
            Games = new List<Game>
            {
                new()
                {
                    Order = 1,
                    BlueTeam = teamA,
                    BlueTeamScore = 8,
                    RedTeam = teamB,
                    RedTeamScore = 10
                },
                new()
                {
                    Order = 2,
                    BlueTeam = teamA,
                    BlueTeamScore = 11,
                    RedTeam = teamB,
                    RedTeamScore = 9
                },
                new()
                {
                    Order = 3,
                    BlueTeam = teamA,
                    BlueTeamScore = 3,
                    RedTeam = teamB,
                    RedTeamScore = 10
                },
            }
        };
        
        var match2 = new Match
        {
            Date = DateTime.Now.AddDays(-2),
            Games = new List<Game>
            {
                new()
                {
                    Order = 1,
                    BlueTeam = teamA,
                    BlueTeamScore = 8,
                    RedTeam = teamB,
                    RedTeamScore = 10
                },
                new()
                {
                    Order = 2,
                    BlueTeam = teamA,
                    BlueTeamScore = 11,
                    RedTeam = teamB,
                    RedTeamScore = 9
                },
                new()
                {
                    Order = 3,
                    BlueTeam = teamA,
                    BlueTeamScore = 3,
                    RedTeam = teamB,
                    RedTeamScore = 10
                },
            }
        };

        return new List<Match> { match1, match2 };
    }
}