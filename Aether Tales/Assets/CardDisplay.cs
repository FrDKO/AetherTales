using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    Card card;
    string type;
    public  Text subTypeText;
    public Text nameText;
    public Text DescriptionText;
    public Text RangeText;
    public Text CostText;
    public Image artSprite;
    public Text DamageText;
    public Text KnockbackText;
    public Image UsedBySprite;

    void Update()
    {
        this.type = card.CardType;
        nameText.text = card.CardName;
        DescriptionText.text = card.CardDescription;
        CostText.text = card.Cost.ToString().Length == 2? card.Cost.ToString() : "0"+card.Cost.ToString();
        //UsedBySprite.sprite = card.usedBy;
        //artSprite.sprite = card.artwork;
        if(type.Equals("Attack"))
        {
        DamageText.text = card.AttackDamage.ToString() + "%";
        KnockbackText.text = card.AttackKnockback.ToString();
        //AttackTypeText.text = card.AttackType;
        RangeText.text = card.AttackRange.ToString();
        }
        else
        {
            DamageText.text = "";
            KnockbackText.text = "";
            RangeText.text = "";
        }
        
    }
    public void setCard(Card c)
    {
        this.card = c;
        Debug.Log(card.showCard());
    }
}
