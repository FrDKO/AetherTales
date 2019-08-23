using System.Collections;
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
    public Text usedByText;
    public Text cardBackground;//Send to card somehow???
    public Texture2D cardArt;
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

        switch(card.CardType)
        {
            case("Attack"):buildAttack();break;
            case("Hazard"):buildHazard();break;
            case("Character"):break;
        }
        card.CardName = cardName.text;
        card.CardDescription = cardDesc.text;
        card.CardType = cardType.text;
        card.CardSubType = cardSubType.text;
        card.CardCost=int.Parse(cardCost.text);
        card.BackGround = cardBackground.text;

        if(!card.characterUsed.Contains("Can be"))
                card.CharacterUsed = usedByText.text;
        else
                card.CharacterUsed = "All";

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
            File.WriteAllBytes(Application.dataPath + "/Resources/CardArt/"+card.CardName+".png",bytes);
            }
            catch{
                Debug.Log("Problems occured with saving the texture");
            }
           
            
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

