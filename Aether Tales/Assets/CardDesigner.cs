using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDesigner : MonoBehaviour
{

    public CardDisplay cardModel;
    Card card;
   
    public void Start()
    {
         card = (Card)ScriptableObject.CreateInstance("Card");
    }

    public void UpdateName(InputField inputField)
    {
        card.CardName = inputField.text;
        cardModel.setCardName(inputField.text);
    }
    public void UpdateType(Text dropdownText)
    { 
        card.CardType = dropdownText.text;
        cardModel.setCardtype(dropdownText.text);
    }
    public void UpdateDescription(InputField inputField)
    {
        card.CardDescription = inputField.text;
        cardModel.setDescriptionText(inputField.text);
    }
    public void UpdateCost(Slider slider)
    {
        card.CardCost = (int)slider.GetComponent<Slider>().value;
        cardModel.setCostSprite(card.CardCost.ToString());
    }

    //Take this selection as Text and parse it so it can be used that way
    public void UpdateUseBy(Text dropdownText)
    {
       card.CharacterUsed = dropdownText.text;
       cardModel.setUsedBySprite(dropdownText.text);
    }

    public void UpdateSubType(Text subTypeText)
    {
        card.CardSubType = subTypeText.text;
        cardModel.setSubType(subTypeText.text);
    }
    public void UpdateDamage(Slider slider)
    {
        card.CardAttackDamage =  (int)slider.GetComponent<Slider>().value;
        cardModel.setDamageSprite(card.CardAttackDamage.ToString());
    }
    public void UpdateKnockback(Slider slider)
    {
        card.CardAttackKnockback =  (int)slider.GetComponent<Slider>().value;
        cardModel.setKnockbackSprite(card.CardAttackKnockback.ToString());
    }
    
    public void UpdateRange(Slider slider)
    {
        card.CardAttackRange =  (int)slider.GetComponent<Slider>().value;
        cardModel.setRangeSprite(card.CardAttackRange.ToString());
    }
    public void UpdateHazardRange(Text hazardRange)
    {
        card.CardHazardRange = hazardRange.text;
        cardModel.setHazardRangeSprite(hazardRange.text);
    }
    void SaveFinalCard()
    {

    }
}
