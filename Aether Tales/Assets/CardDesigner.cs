using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDesigner : MonoBehaviour
{

    Card card;
    public void Start()
    {
         card = (Card)ScriptableObject.CreateInstance("Card");
    }
    public GameObject modelCard;
    // Update is called once per frame

    public void UpdateName(Text nameText)
    {
        
        card.CardName = nameText.text;
        UpdateModel();
    }
    public void UpdateType(Text dropdownText)
    { 
        card.CardType = dropdownText.text;
        UpdateModel();
    }
    public void UpdateDescription(Text DescriptionText)
    {
        card.CardDescription = DescriptionText.text;
        UpdateModel();
    }
    public void UpdateCost(Slider slider)
    {
        card.Cost = (int)slider.GetComponent<Slider>().value;
        UpdateModel();
    }

    public void UpdateUseBy(Image image)
    {
        card.usedBy = image.sprite;
        UpdateModel();
    }

    public void UpdateAttackType(Text attackText)
    {
        card.AttackType = attackText.text;
        UpdateModel();
    }
    public void UpdateDamage(Slider slider)
    {
        card.AttackDamage =  (int)slider.GetComponent<Slider>().value;
        UpdateModel();
    }
    public void UpdateKnockback(Slider slider)
    {
        card.AttackKnockback =  (int)slider.GetComponent<Slider>().value;
        UpdateModel();
    }
    
    public void UpdateRange(Slider slider)
    {
        card.AttackRange =  (int)slider.GetComponent<Slider>().value;
        UpdateModel();
    }
    
    public void UpdateModel()
    {
        modelCard.GetComponent<CardDisplay>().setCard(card);
    }

    void SaveFinalCard()
    {

    }
}
