using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck: CardZone
{
    public Card draw()
    {
       Card temp = getCardList()[0];
       getCardList().RemoveAt(0);
       return getCardList()[0];
    }

    public Card sendToTop(Card c)
    {
        getCardList().Insert(0,c);
        return c;
    }

    public Card sendToBottom(Card c)
    {
        addCard(c);
        return c;
    }

    public void shuffle()
    {
       setCardList(new Shuffler<Card>().shuffle(getCardList())); 
    }

}
