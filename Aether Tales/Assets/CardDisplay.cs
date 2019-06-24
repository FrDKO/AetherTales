using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    Card card;
    Text TypeText;
    Text nameText;
    Text DescriptionText;
    Text RangeText;
    Text CostText;
    Image artSprite;
    Text DamageText;
    Text KnockbackText;
    Text AttackTypeText;
    Image UsedBySprite;
    void Start()
    {
        nameText = transform.Find("Name").GetComponent<Text>();
        DescriptionText = transform.Find("Description").GetComponent<Text>();
        TypeText = transform.Find("Type").GetComponent<Text>();
        RangeText = transform.Find("Range").GetComponent<Text>();
        CostText = transform.Find("Cost").GetComponent<Text>();
        artSprite = transform.Find("Art").GetComponent<Image>();
        DamageText = transform.Find("Damage").GetComponent<Text>();
        KnockbackText = transform.Find("Knockback").GetComponent<Text>();
        AttackTypeText = transform.Find("Type").GetComponent<Text>();
        UsedBySprite = transform.Find("Character").GetComponent<Image>();
    }
    void Update()
    {
        nameText.text = card.CardName;
        DescriptionText.text = card.CardDescription;
        TypeText.text = card.CardType;
        CostText.text = card.Cost.ToString().Length == 2? card.Cost.ToString() : "0"+card.Cost.ToString();
        UsedBySprite.sprite = card.usedBy;
        artSprite.sprite = card.artwork;
        if(TypeText.text.Equals("Attack"))
        {
        DamageText.text = card.AttackDamage.ToString();
        KnockbackText.text = card.AttackKnockback.ToString();
        AttackTypeText.text = card.AttackType;
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
