using System;
using System.Linq;
using System.Collections.Generic;
using Codenation.Challenge.Exceptions;
using Source;

namespace Codenation.Challenge
{
    public class SoccerTeamsManager : IManageSoccerTeams
    {
        private List<Team> teams;
        private List<Player> players;

        public SoccerTeamsManager()
        {
            teams = new List<Team>();
            players = new List<Player>();
        }

        public void AddTeam(long id, string name, DateTime createDate, string mainShirtColor, string secondaryShirtColor)
        {
            SafeNotHasTeam(id);

            teams.Add(new Team(id, name, createDate, mainShirtColor, secondaryShirtColor));
        }

        public void AddPlayer(long id, long teamId, string name, DateTime birthDate, int skillLevel, decimal salary)
        {
            SafeNotHasPlayer(id);
            Team team = GetTeam(teamId);

            players.Add(new Player(id, teamId, name, birthDate, skillLevel, salary));
        }

        public void SetCaptain(long playerId)
        {
            Player player = GetPlayer(playerId);
            Team team = GetTeam(player.TeamId);

            team.Captain = playerId;

            long cap = GetTeamCaptain(1232);
        }

        public long GetTeamCaptain(long teamId)
        {
            Team team = GetTeam(teamId);

            return GetCaptain(team);
        }

        public string GetPlayerName(long playerId)
        {
            Player player = GetPlayer(playerId);

            return player.Name;
        }

        public string GetTeamName(long teamId)
        {
            Team team = GetTeam(teamId);

            return team.Name;
        }

        public List<long> GetTeamPlayers(long teamId)
        {
            Team team = GetTeam(teamId);

            return GetPlayersOfTeam(teamId)
                .Select(p => p.Id)
                .ToList();
        }

        public long GetBestTeamPlayer(long teamId)
        {
            SafeHasTeam(teamId);

            Player bestPlayer = GetPlayersOfTeam(teamId)
                .OrderByDescending(p => p.SkillLevel)
                .FirstOrDefault();

            return bestPlayer.Id;
        }

        public long GetOlderTeamPlayer(long teamId)
        {
            SafeHasTeam(teamId);

            Player bestPlayer = GetPlayersOfTeam(teamId)
                .OrderBy(p => p.BirthDate)
                .FirstOrDefault();

            return bestPlayer.Id;
        }

        public List<long> GetTeams()
        {
            return teams.OrderBy(t => t.Id).Select(t => t.Id).ToList();
        }

        public long GetHigherSalaryPlayer(long teamId)
        {
            SafeHasTeam(teamId);

            Player bestPlayer = GetPlayersOfTeam(teamId)
                .OrderByDescending(p => p.Salary)
                .FirstOrDefault();

            return bestPlayer.Id;
        }

        public decimal GetPlayerSalary(long playerId)
        {
            return GetPlayer(playerId).Salary;
        }

        public List<long> GetTopPlayers(int top)
        {
            return players.OrderBy(p => p.Id)
                .OrderByDescending(p => p.SkillLevel)
                .Select(p => p.Id)
                .ToList()
                .GetRange(0, top);
        }

        public string GetVisitorShirtColor(long teamId, long visitorTeamId)
        {
            Team homeTeam = GetTeam(teamId);
            Team visitorTeam = GetTeam(visitorTeamId);

            if (homeTeam.MainShirtColor.Equals(visitorTeam.MainShirtColor))
                return visitorTeam.SecondaryShirtColor;
            else
                return visitorTeam.MainShirtColor;
        }

        #region [ Utils ]
        private Team GetTeam(long teamId)
        {
            Team team = teams.Find(t => t.Id == teamId);

            if (team == null)
                throw new TeamNotFoundException();

            return team;
        }
        private Player GetPlayer(long playerId)
        {
            Player player = players.Find(t => t.Id == playerId);

            if (player == null)
                throw new PlayerNotFoundException();

            return player;
        }

        private List<Player> GetPlayersOfTeam(long teamId)
        {
            return players.Where(p => p.TeamId == teamId).OrderBy(p => p.Id).ToList();

            List<Player> playerss = new List<Player>();

            foreach(var p in players)
            {
                if(p.TeamId == teamId)
                {
                    players.Add(p);
                }
            }
        }

        private long GetCaptain(Team team)
        {
            long captain = team.Captain;

            if (captain == 0)
                throw new CaptainNotFoundException();

            return captain;
        }

        private void SafeHasTeam(long teamId)
        {
            if (!teams.Any(t => t.Id == teamId))
                throw new TeamNotFoundException();
        }

        private void SafeNotHasTeam(long teamId)
        {
            if (teams.Any(t => t.Id == teamId))
                throw new UniqueIdentifierException();
        }
        private void SafeHasPlayer(long playerId)
        {
            if (!players.Any(t => t.Id == playerId))
                throw new TeamNotFoundException();
        }

        private void SafeNotHasPlayer(long playerId)
        {
            if (players.Any(t => t.Id == playerId))
                throw new UniqueIdentifierException();
        }
        #endregion
    }
}
