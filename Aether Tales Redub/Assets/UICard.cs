using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class UICard : MonoBehaviour, IPointerEnterHandler
{
    public GameObject EnlargedCard;

    public void setEnlargedCard(GameObject g)
    {
        EnlargedCard = g;
    }
    public void OnPointerEnter(PointerEventData pointerEvent)
    {
        EnlargedCard.GetComponent<CardDisplay>().loadView(this.gameObject.GetComponent<CardDisplay>().getCard());
        EnlargedCard.GetComponent<CardDisplay>().setCardArt(this.gameObject.GetComponent<CardDisplay>().cardArt.sprite);
    }
}
