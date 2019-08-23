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

    public void loadView(Card c)
    {
    
       this.card = c;
       Debug.Log(c.showCard());

       switch(card.cardType)
       {
           case("Attack"):buildAttack();break;
           case("Hazard"):buildHazard();break;
           case("Character"):break;
           default: buildOther(); break;
       }
       cardName.text = card.cardName;
       cardDescription.text = card.cardDescription;
       cardSubType.text = card.cardSubType;
       cardBackground.sprite = fetcher.LoadFromPath("CardTemplates/Backgrounds",card.BackGround);
       characterUsed.sprite = fetcher.LoadFromPath("CardTemplates/Universal/UseSymbols",card.characterUsed);
       cardType.sprite = fetcher.LoadFromPath("CardTemplates/CardTextures",card.cardType);
       cardArt.sprite = fetcher.LoadFromPath("CardArt",card.cardName);
       LoadCosts();
    }

    private void buildAttack()
    {
       cardSubType.gameObject.transform.localPosition = new Vector2(12,-47);
       cardAttackKnockback.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Knockback",""+card.cardAttackKnockback);
       cardAttackRange.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Range",""+card.cardAttackRange);
       LoadDamage();
       cardHazardRange.gameObject.SetActive(false);
    }
    private void buildHazard()
    {
            cardSubType.gameObject.transform.localPosition = new Vector2(12,-47);
             cardHazardRange.sprite = fetcher.LoadFromPath("CardTemplates/Hazard",card.CardHazardRange);
             cardAttackRange.gameObject.SetActive(false);
             cardAttackKnockback.gameObject.SetActive(false);
             cardAttackDamageDigit1.gameObject.SetActive(false);
             cardAttackDamageDigit2.gameObject.SetActive(false);

    }
    private void buildCharacter()
    {

    }
    private void buildOther()
    {
        cardSubType.gameObject.transform.localPosition = new Vector2(-26,-47);
        cardAttackKnockback.gameObject.SetActive(false);
        cardAttackDamageDigit1.gameObject.SetActive(false);
        cardAttackDamageDigit2.gameObject.SetActive(false);
        cardAttackRange.gameObject.SetActive(false);
        cardHazardRange.gameObject.SetActive(false);
    }
    private void LoadCosts()
    {
        //Assume Cost = 7
        string x = ""+card.cardCost; //"7"
        if(card.cardCost < 10) // two digits
        {
            x = "0"+x;//"07"
        }   

        switch(x)
        {
            case("10"):
            {
            cardCostDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/FirstDigit","1");
            cardCostDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/SecondDigit","0Full");
            break;
            }
            case("00"):   
            {
            cardCostDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/FirstDigit","0");
            cardCostDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/SecondDigit","0");
            break;
            }
            default: 
            {
            cardCostDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/FirstDigit","0");
            cardCostDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Universal/Cost/SecondDigit",x[1].ToString());//"7"
            break;
            }
        }
        
    }

    private void LoadDamage()
    {
        string x = ""+card.cardAttackDamage; 
        if(x.Length<2) // two digits
        {
            x = "0"+x;
        }
            cardAttackDamageDigit1.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Damage/FirstDigit",x[0].ToString());
            cardAttackDamageDigit2.sprite = fetcher.LoadFromPath("CardTemplates/Attack/Damage/SecondDigit",x[1].ToString());

    }
}
