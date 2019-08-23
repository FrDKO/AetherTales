using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardLoader : MonoBehaviour
{
    Fetcher fetcher = new Fetcher();
    Card[] allCards;
    
    public GameObject Card;
    void OnEnable()
    {
    Debug.Log("Loading Cards");
      allCards =  fetcher.LoadAllCards();
      foreach(Card c in allCards)
      {
          if(c.Equals("Null"))
          Debug.Log("Card Cannot be found");
          GameObject newCard = Instantiate(Card,new Vector3(0,0,0),Quaternion.identity) as GameObject;
          newCard.GetComponent<CardDisplay>().loadView(c);
          newCard.name = c.cardName;
      }
    }

}
