using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldCup.Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }

        public string Team1 { get; set; }

        public string Team2 { get; set; }

        public string Winner { get; set; }

        public bool Over { get; set; }


        public void Play()
        {
            Random rand = new Random();
            if (rand.NextDouble() >= 0.5)
            {
                this.Winner = this.Team1;
            }
            else
            {
                this.Winner = this.Team2;
            }

            this.Over = true;

        }

    }
}
