using System;
using System.Collections.Generic;
using System.Text;

namespace Exo2
{
    class Chat : ICloneable
    {
        public String name { get; set; } = null;
        public readonly int nbTete = 2;

        public Chat(string name) {
            this.name = name;
        }

        public object Clone()
        {
            return new Chat(name);
        }
    }
}
