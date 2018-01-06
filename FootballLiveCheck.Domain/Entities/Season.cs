using System;
using System.Collections.Generic;
using System.Text;

namespace FootballLiveCheck.Domain.Entities
{
    public class Season : ApiEntity
    {
        private Season()
        {
        }

        public string Name { get; private set; }

        public IEnumerable<Match> Matches { get; private set; }

    }
}
