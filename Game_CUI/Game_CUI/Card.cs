using System;
using System.Collections.Generic;
using System.Text;

namespace Game_CUI
{
    internal class Card
    {
        internal int ID { get; private set; }
        internal string Name { get; private set; }
        internal delegate void Effect(object a);

        internal Card(int ID, string Name)
        {
            this.ID = ID;
            this.Name = Name;
        }

        override public string ToString()
        {
            return $"{ID}, {Name}";
        }

    }
}
