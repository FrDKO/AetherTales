using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public void OnEnable()
    {
        card = (Card)ScriptableObject.CreateInstance("Card");
    }
    public Card getCard()
    {
        return this.card;
    }
    public void Update()
    {
        card.CardName = cardName.text;
        card.CardDescription = cardDesc.text;
        card.CardType = cardType.text;
        card.CardCost=int.Parse(cardCost.text);
        card.CardSubType = cardSubType.text;
        card.CardAttackDamage = int.Parse(cardAttackDamage.text);
        card.CardAttackKnockback = int.Parse(cardAttackKnockback.text);
        card.CardAttackRange = int.Parse(cardAttackRange.text);
        card.CardHazardRange = cardHazardRange.text;
        if(card.CardSubType.Equals(""))
            card.cardSubType = "Normal";
        
    }

    public void finalizeCard()
    {
        Validate();
        ScriptableObjectUtility.CreateAsset<Card>(card);
    }
    private void Validate()
    {
        if(card.CardType.Equals("Attack"))
        {
            card.CardHazardRange = "";
        }
        if(card.CardType.Equals("Hazard"))
        {
            card.CardAttackDamage= 0;
            card.CardAttackKnockback= 0;
            card.CardAttackRange = 0;
        }
        if(card.CardType.Equals("Character"))
        {
            
        }
        else
        {
                card.CardHazardRange = "";
                card.CardAttackDamage = 0;
                card.CardAttackKnockback = 0;
                card.CardAttackRange=0;
        }
    }

}

