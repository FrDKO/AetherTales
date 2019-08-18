using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand:CardZone
{
    private const int handSizeLimit = 7;

    public Card discard(Card c)
    {
        return getCard(c);
    }

    public Card playCard(Card card)
    {
        getCard(card);
        //card.activate();
        return card;
    }

    public bool isOverLimit()
    {
        if(getCardList().Count>handSizeLimit)
        {
            return true;
        }
        return false;
    }


}
