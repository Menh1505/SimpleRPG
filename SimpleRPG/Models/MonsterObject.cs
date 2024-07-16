using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG.Models
{
    public class MonsterObject : CoreObject
    {
        public int dodgeRate { get; set; }

        public MonsterObject() : base()
        {
            dodgeRate = 0;
        }
    }
}
