using BackendAPI.Models.Leaderboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Services.Leaderboard
{
    public interface ILeaderboardService
    {
        List<LeaderboardRecordModel> GetLeaderboard();
    }
}
