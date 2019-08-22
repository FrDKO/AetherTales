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
    public Text usedByText;
    public Text cardBackground;//Send to card somehow???
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
        Debug.Log(card.showCard());
    }

    public void finalizeCard()
    {
        Validate();
        try
        {
           ScriptableObjectUtility.CreateAsset<Card>(card); 
           //StartCoroutine("WaitTimer()");
        }
        catch
        {
            Debug.Log(card.showCard());
        }
    }
    private void Validate()
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
        card.CharacterUsed = usedByText.text;
        card.BackGround = cardBackground.text;
        if(card.CardSubType.Equals(""))
        {
            switch(card.cardType)
            {
                case("Attack"): card.cardSubType = "Ground Attack"; break;
                default: card.cardSubType = "Normal"; break;
            }
        }
        switch(card.CardType)
        {
            case("Attack"):nonHazard();break;
            case("Hazard"):nonAttack();break;
            case("Character"):break;
            default:nonAttack();nonHazard();break;
        }

    }
    public void nonAttack()
    {
        card.CardAttackDamage = 0;
        card.CardAttackKnockback = 0;
        card.CardAttackRange = 0;
    }
    public void nonHazard()
    {
        card.CardHazardRange = "";
    }

    public void buildCharacterCard()
    {

    }

}

