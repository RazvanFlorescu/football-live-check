using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace FootballLiveCheck.Domain.Entities
{
    public class Arena:ApiEntity
    {
        public int Capacity { get; private set; }

        public string Name { get; private set; }

        public static Arena Create(int dbid, string name, int capacity)
        {
            return new Arena()
            {
                Id = dbid,
                Name= name,
                Capacity = capacity
            };
        }
    }
}
