using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG.Models
{
    public class PlayerObject : CoreObject
    {
        public int criticalRate { get; set; }
        public int criticalDamage { get; set; }

        public PlayerObject() : base() 
        {
            criticalDamage = 0;
            criticalRate = 0;
        }
    }
}
