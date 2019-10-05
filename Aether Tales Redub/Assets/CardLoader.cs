using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardLoader : MonoBehaviour
{
    public GameObject EnlargedCard;
    public ArtLoader artLoader;
    public Card[] allCards;
    public GameObject Card;
    public Transform Parent;

    public GameObject TextObject;
  
    public void LoadTheDatabase()
    {
      if(!checkListSize())
      {
        foreach(Card c in allCards)
        {
          TextObject.GetComponent<Text>().text = c.cardName + "|Type: "+ c.cardType+ "|cost: "+ c.CardCost.ToString();
          Instantiate(TextObject,Parent);
          GameObject newCard = Instantiate(Card,Parent) as GameObject;
          newCard.GetComponent<CardDisplay>().loadView(c);
          newCard.GetComponent<CardDisplay>().setCardArt(artLoader.getArt(c.cardName));
          newCard.AddComponent<UICard>();
          newCard.GetComponent<UICard>().setEnlargedCard(EnlargedCard);
        }
      }
      else
      {
        foreach(Transform t in Parent)
        {
          if(t.gameObject.GetComponent<CardDisplay>())
            t.gameObject.GetComponent<CardDisplay>().loadView();
        }
      }
    }
    public bool checkListSize()
    {
      return Parent.childCount<allCards.Length?false:true;
    }
    

}
