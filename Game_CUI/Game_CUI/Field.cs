using System;
using System.Collections.Generic;
using System.Text;

namespace Game_CUI
{
    class Field
    {
        List<Card> cards;
        Field()
        {
            cards = new List<Card>();
        }

        internal void Summons(Card card)
        {
            cards.Add(card);

        }
        internal void Delete(int index)
        {
            if (cards.Count >= index)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                cards.RemoveAt(index);
            }
        }
    }
}
