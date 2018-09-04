using System;
using System.Collections.Generic;
using System.Text;

namespace Game_CUI
{
    class Graveyard
    {
        Stack<Card> cards;

        Graveyard()
        {
            cards = new Stack<Card>();
        }

        internal void SendGraveyard(Card card)
        {
            cards.Push(card);

        }

    }
}
