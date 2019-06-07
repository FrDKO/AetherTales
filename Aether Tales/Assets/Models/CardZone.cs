using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardZone 
{
     List<Card> cardList = new List<Card>();

    public List<Card> getCardList()
    {
        return cardList;
    }

    public void setCardList(List<Card> list)
    {
        cardList = list;
    }
    public Card getCard(Card card)
    {
        cardList.Remove(card);
        return card;
    }
    public Card addCard(Card card)
    {
        card.Location = this.GetType().Name;
        cardList.Add(card);
        return card;
    }
}
