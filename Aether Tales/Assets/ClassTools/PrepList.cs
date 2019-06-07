using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrepList
{
    //When a card is in a playable zone, its information will be sent to here if it has a Trigger effect
    //While that cards information is here, any time an action happens, the list of cards on the Trigger will be checked
    //If a card effect is triggered it is returned and the cards activator becomes active. 
    List<Card> triggerList = new List<Card>();

    public void addNewCard(Card c)
    {
        triggerList.Add(c);
    }

    public List<Card> checkAll(string TriggerString)
    {
        List<Card> callBackList = new List<Card>();
        foreach(Card card in triggerList)
        {
            if(card.Trigger == TriggerString)
            {
                callBackList.Add(card);
            }
        }
        return callBackList;
    }
}
