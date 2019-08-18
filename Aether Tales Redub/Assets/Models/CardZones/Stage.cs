using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage: CardZone
{
    private int stageSize;
    private List<Card> hazardList = new List<Card>();
    public void setStageSize(int stageSize)
    {
        this.stageSize = stageSize;
        for(int i = 0; i<stageSize;i++)
        {
            hazardList.Add(new Card()); //Adding blank cards to the hazard List
        }
    }

    public Card replace(Card newCard,Card oldCard)
    {
        int placement = getCardList().IndexOf(oldCard);
        Card tempCard = getCard(oldCard);
        getCardList().Insert(placement,newCard);
        return tempCard;
    }

    public Card flipCard (int placement)
    {
        return getCardList()[placement];
    }
    
    public string placeHazard(Card hazardCard, int placement)
    {
        hazardList[placement] = hazardCard;
        return "Hazard Placed";
    }

    public string removeHazard(int placement)
    {
        hazardList[placement] = new Card();
        return "Hazard Removed";
    }
  
    

}
