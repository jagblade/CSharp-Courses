using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private readonly List<Player> players;
        public IReadOnlyCollection<Player> Players => (IReadOnlyCollection<Player>)players;

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }

        public Team(string name, int openPositions, char group)
        {
            players = new List<Player>();
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;
        }

        public int Count => players.Count;

        public string AddPlayer(Player player)
        {
            if (string.IsNullOrEmpty(player.Name) || string.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if ( OpenPositions <= 0)
            {
                return "There are no more open positions.";
            }
            if (player.Rating < 80)
            {
                return "Invalid player's rating.";
            }
            
            players.Add(player);
            OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";

            
        }
        public bool RemovePlayer(string name)
        {
            var exist = this.players.FirstOrDefault(x => x.Name == name);

            if (exist != null)
            {
                OpenPositions++;    
                return players.Remove(exist);
            }
            return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            int count = 0;

            var playersStartCount = players.Count;

            players.RemoveAll(x => x.Position == position);

            count = playersStartCount - players.Count;

            return count;

        }

        public Player RetirePlayer(string name)
        {
            var player = this.players.FirstOrDefault(x => x.Name == name);
            this.players.FirstOrDefault(x => x.Name == name).Retired = true;
            player.Retired = true;

            return player;
        }

        public List<Player> AwardPlayers(int games)
        {
            List<Player> list = new List<Player>();
            list = this.players.Where(x => x.Games >= games).ToList();
            return list;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Active players competing for Team {this.Name} from Group {this.Group}:");
            foreach (var p in players.Where(x => x.Retired == false))
            {
                sb.AppendLine(p.ToString());
            }
            return sb.ToString().TrimEnd();

        }
    }
}