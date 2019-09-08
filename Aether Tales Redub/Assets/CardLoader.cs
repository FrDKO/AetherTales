using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardLoader : MonoBehaviour
{
    public ArtLoader artLoader;
    public Card[] allCards;
    public GameObject Card;
    public Transform Parent;

    public GameObject TextObject;
  
    public void LoadTheDatabase()
    {
      foreach(Card c in allCards)
      {
        TextObject.GetComponent<Text>().text = c.cardName + "|Type: "+ c.cardType+ "|cost: "+ c.CardCost.ToString();
        Instantiate(TextObject,Parent);
        GameObject newCard = Instantiate(Card,Parent) as GameObject;
        newCard.GetComponent<CardDisplay>().loadView(c);
        newCard.GetComponent<CardDisplay>().setCardArt(artLoader.getArt(c.cardName));
        newCard.AddComponent<InteractiveUI>();
      }
    }

}
