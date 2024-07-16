using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG.Models
{
    public abstract class CoreObject
    {
        public string name { get; set; }
        public int health { get; set; }
        public int damage { get; set; }

        public CoreObject() 
        {
            health = 0;
            damage = 0;
        }
    }
}
