using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{

    public bool isMaster;
    Card card;
    public Text cardName;
    public Text cardDescription;
    public Text cardSubType;
    public SpriteImage cardBackground;
    public SpriteImage cardCostDigit1;
    public SpriteImage cardCostDigit2;
    public SpriteImage cardAttackRange;
    public SpriteImage cardAttackDamageDigit1;
    public SpriteImage cardAttackDamageDigit2;
    public SpriteImage cardAttackKnockback;
    public SpriteImage characterUsed;
    public SpriteImage cardHazardRange;
    public SpriteImage cardType;

    public Image cardArt;

    public Card getCard()
    {
        return card;
    }
    public void loadView()
    {
       switch(card.cardType)
       {
           case("Attack"):buildAttack();break;
           case("Hazard"):buildHazard();break;
           case("Character"):break;
           default: buildOther(); break;
       }
       cardName.text = card.cardName;
       cardDescription.text = card.cardDescription;
       if(!card.cardSubType.Equals("Normal"))
       cardSubType.text = card.cardSubType;
       else
       cardSubType.text = "";
       cardBackground.setSprite(card.BackGround);
       characterUsed.setSprite(card.CharacterUsed);
       cardType.setSprite(card.CardType);
       LoadCosts();
    }
    public void loadView(Card c)
    {
       if(isMaster)
    this.gameObject.transform.localScale = new Vector3 (1,1,1);
       this.gameObject.SetActive(true);
       this.card = c;
       switch(card.cardType)
       {
           case("Attack"):buildAttack();break;
           case("Hazard"):buildHazard();break;
           case("Character"):break;
           default: buildOther(); break;
       }
       cardName.text = card.cardName;
       cardDescription.text = card.cardDescription;
       if(!card.cardSubType.Equals("Normal"))
       cardSubType.text = card.cardSubType;
       else
       cardSubType.text = "";
       cardBackground.setSprite(card.BackGround);
       characterUsed.setSprite(card.CharacterUsed);
       cardType.setSprite(card.CardType);
       LoadCosts();
    }

    public void setCardArt(Sprite s)
    {
        cardArt.sprite = s;
    }

    private void buildAttack()
    {
       cardSubType.gameObject.transform.localPosition = new Vector2(12,-43);
       cardAttackKnockback.gameObject.SetActive(true);
       cardAttackKnockback.setSprite(card.CardAttackKnockback.ToString());
       cardAttackRange.gameObject.SetActive(true);
       cardAttackRange.setSprite(card.CardAttackRange.ToString());
       LoadDamage();
       cardHazardRange.gameObject.SetActive(false);
    }
    private void buildHazard()
    {
            cardSubType.gameObject.transform.localPosition = new Vector2(12,-43);
             cardHazardRange.setSprite(card.CardHazardRange);
             cardHazardRange.gameObject.SetActive(true);

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
        cardSubType.gameObject.transform.localPosition = new Vector2(-26,-43);
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
            cardCostDigit1.setSprite("1");
            cardCostDigit2.setSprite("0Full");
            break;
            }
            case("00"):   
            {
            cardCostDigit1.setSprite("0");
            cardCostDigit2.setSprite("0");
            break;
            }
            default: 
            {
            cardCostDigit1.setSprite("0");
            cardCostDigit2.setSprite(x[1].ToString());//"7"
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
        cardAttackDamageDigit1.gameObject.SetActive(true);
            cardAttackDamageDigit1.setSprite(x[0].ToString());
        cardAttackDamageDigit2.gameObject.SetActive(true);
            cardAttackDamageDigit2.setSprite(x[1].ToString());

    }

    public float scaleFactor = 1;

    
    void OnEnable()
    {
        cardArt.gameObject.SetActive(true);
        this.gameObject.transform.localScale = transform.parent.localScale/1.8f;
    }
}
