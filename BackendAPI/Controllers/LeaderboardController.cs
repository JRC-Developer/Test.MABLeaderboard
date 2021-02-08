using BackendAPI.Services.Leaderboard;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly ILeaderboardService _leaderboardService;

        public LeaderboardController(ILeaderboardService leaderboardService)
        {
            _leaderboardService = leaderboardService;
        }

        [Route("leaderboard")]
        [HttpGet]
        public IActionResult GetLeaderboard()
        {
            return Ok(_leaderboardService.GetLeaderboard());
        }
    }
}
