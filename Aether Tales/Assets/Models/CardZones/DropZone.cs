using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropZone: CardZone
{
    public const int costLimit = 15;

    public List<Card> clear()
    {
        List<Card> tempList = getCardList();
        getCardList().Clear();
        return tempList;
    }

    private List<Card> forceClear()
    {
        //Do penalty
        return clear();
    }
    public Card clear(Card card)
    {
        return getCard(card);
    }

    new public Card addCard(Card card)
    {
        base.addCard(card);
        if(isOverLimit())
        {
            forceClear();
        }
        return card;
    }

    public bool isOverLimit()
    {
        int totalCost = 0;
        foreach(Card card in getCardList())
        {
            if(card.IsFlipped)
            totalCost += card.CardCost;
        }
        if(totalCost > costLimit)
        {
            return true;
        }
        return false;
    }
    
}
