using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardLoader : MonoBehaviour
{
    Fetcher fetcher = new Fetcher();
    Card[] allCards;
    
    public GameObject Card;
    public Transform Parent;
    void OnEnable()
    {
    Debug.Log("Loading Cards");
      allCards =  fetcher.LoadAllCards();
      foreach(Card c in allCards)
      {
          if(c.Equals("Null"))
          Debug.Log("Card Cannot be found");
          GameObject newCard = Instantiate(Card,Parent) as GameObject;
          newCard.GetComponent<CardDisplay>().loadView(c);
          newCard.name = c.cardName;
      }
    }

}
