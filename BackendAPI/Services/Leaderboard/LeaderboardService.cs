using BackendAPI.Models.Leaderboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Services.Leaderboard
{
    public class LeaderboardService : ILeaderboardService
    {
        private List<LeaderboardRecordModel> _leaderboardRecordsList;
        public LeaderboardService()
        {
            _leaderboardRecordsList = new List<LeaderboardRecordModel>()
            {
                new LeaderboardRecordModel()
                {
                    UserID = 1,
                    Score = 100,
                    GamesPlayed = 50
                },
                new LeaderboardRecordModel()
                {
                    UserID = 2,
                    Score = 80,
                    GamesPlayed = 43
                },
                new LeaderboardRecordModel()
                {
                    UserID = 3,
                    Score = 73, GamesPlayed = 26
                }
            };
        }
        public List<LeaderboardRecordModel> GetLeaderboard()
        {
            return _leaderboardRecordsList;
        }
    }
}
