using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{

    Fetcher fetcher = new Fetcher();
    Card card;

    public Text cardName;
    public Text cardDescription;
    public Text cardSubType;
    public Image cardBackground;
    public Image cardCostDigit1;
    public Image cardCostDigit2;
    public Image cardAttackRange;
    public Image cardAttackDamageDigit1;
    public Image cardAttackDamageDigit2;
    public Image cardAttackKnockback;
    public Image characterUsed;
    public Image cardHazardRange;
    public Image cardType;

    public Image cardArt;

    public void View(Card c)
    {
       this.card = c;
       cardName.text = card.cardName;
       cardDescription.text = card.cardDescription;
       cardSubType.text = card.cardSubType;
       cardBackground.sprite = fetcher.LoadFromPath("CardTemplates/Backgrounds",card.BackGround).sprite;
       cardAttackRange.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Knockback",""+card.cardAttackKnockback).sprite;
       cardAttackRange.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Range",""+card.cardAttackRange).sprite;
       characterUsed.sprite = fetcher.LoadFromPath("CardTemplates/Universal/UseSymbols",card.characterUsed).sprite;
       cardHazardRange.sprite = fetcher.LoadFromPath("CardTemplates/Hazard",card.CardHazardRange).sprite;
       cardType.sprite = fetcher.LoadFromPath("CardTemplates/CardTextures",card.cardType).sprite;
       cardArt.sprite = fetcher.LoadFromPath("CardArt",card.cardName).sprite;
       LoadCosts();
       LoadDamage();
    }

    private void LoadCosts()
    {
        if(card.cardCost>0 && card.cardCost<10)
        {
            cardAttackDamageDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/FirstDigit","0").sprite;
            cardAttackDamageDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/SecondDigit",""+card.cardCost).sprite;
        }
        else if(card.cardCost.Equals(0))
        {
            cardAttackDamageDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/FirstDigit","0").sprite;
            cardAttackDamageDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/SecondDigit","0Empty").sprite;
        }
        else if (card.cardCost.Equals(10))
        {
            cardAttackDamageDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/FirstDigit","1").sprite;
            cardAttackDamageDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/SecondDigit","0Full").sprite;
        }
    }

    private void LoadDamage()
    {
        string x = ""+card.cardCost; 
        if(x.Length<2) // two digits
        {
            cardAttackDamageDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Damage/FirstDigit","0").sprite;
            cardAttackDamageDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Damage/SecondDigit",""+card.CardAttackDamage).sprite;
        }
        else if (x.Length.Equals(2))
        {
            cardAttackDamageDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Damage/FirstDigit",x[0].ToString()).sprite;
            cardAttackDamageDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Damage/SecondDigit",x[1].ToString()).sprite;
        }

    }
}
