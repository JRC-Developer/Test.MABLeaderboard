using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendAPI.Models.Leaderboard
{
    public class LeaderboardRecordModel
    {
        public int UserID { get; set; }
        public int Score { get; set; }
        public int GamesPlayed { get; set; }
    }
}
