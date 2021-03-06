﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public  class CardDataContainer: MonoBehaviour
{
    Card card;
    ScriptableObjectUtility ScriptableObjectUtility = new ScriptableObjectUtility();
    public Text cardName;
    public Text cardDesc;
    public Text cardType;
    public Text cardCost;
    public Text cardSubType;
    public Text cardAttackDamage;
    public Text cardAttackKnockback;
    public Text cardAttackRange;
    public Text cardHazardRange;
    public Image UsedByImage;
    public Text cardBackground;
    Texture2D cardArt;
    public void OnEnable()
    {
        card = (Card)ScriptableObject.CreateInstance("Card");
    }
    public Card getCard()
    {
        return this.card;
    }

    public void finalizeCard()
    {
        Validate();
        try
        {
           Debug.Log("Card is being turned into asset");
           ScriptableObjectUtility.CreateAsset<Card>(card); 
           //StartCoroutine("WaitTimer()");
        }
        catch
        {
            Debug.Log(card.showCard());
        }
    }
    public void DeliverArt(Texture2D texture)
    {
        this.cardArt = texture;
    }
    private void Validate()
    {   
        card.CardName = cardName.text;
        card.CardDescription = cardDesc.text;
        card.CardType = cardType.text;
        card.CardSubType = cardSubType.text;
        card.CardCost=int.Parse(cardCost.text);
        card.BackGround = cardBackground.text;
        card.CharacterUsed = UsedByImage.sprite.name;

        switch(card.CardType)
        {
            case("Attack"):buildAttack();break;
            case("Hazard"):buildHazard();break;
            case("Character"):break;
        }

         if(card.CardSubType.Equals("") || card.CardSubType.Contains("Type"))
        {
            switch(card.cardType)
            {
                case("Attack"): card.cardSubType = "Ground Attack"; break;
                default: card.cardSubType = "Normal"; break;
            }
        }
            
            var bytes= cardArt.EncodeToPNG();
            try{
            File.WriteAllBytes(Application.dataPath + "CardArt/"+card.CardName+".png",bytes);
            }
            catch{
                Debug.Log("Problems occured with saving the texture");
            }
            Debug.Log("Card has been validated");
    }

    public void buildAttack()
    {
        card.CardAttackDamage = int.Parse(cardAttackDamage.text);
        card.CardAttackKnockback = int.Parse(cardAttackKnockback.text);
        card.CardAttackRange = int.Parse(cardAttackRange.text);
        card.CardHazardRange = "";
    }
    public void buildHazard()
    {
        card.CardAttackDamage = 0;
        card.CardAttackKnockback = 0;
        card.CardAttackRange = 0;
        card.cardHazardRange = cardHazardRange.text;
    }

    public void buildCharacterCard()
    {

    }

}

