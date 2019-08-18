using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Card: ScriptableObject
{
    public string cardName;
    public string cardType;
    public string cardDescription;
    public int cardAttackRange;
    public int cardAttackDamage;
    public int cardAttackKnockback;
    public string characterUsed;
    public string cardSubType;

    public string cardHazardRange;
    public string effect;
    public string trigger;
    public string location;
    public int cardCost;

    public string CardName { get => cardName; set => cardName = value; }
    public string CardType { get => cardType; set => cardType = value; }
    public string CardDescription { get => cardDescription; set => cardDescription = value; }
    public int CardAttackRange { get => cardAttackRange; set => cardAttackRange = value; }
    public int CardAttackDamage { get => cardAttackDamage; set => cardAttackDamage = value; }
    public int CardAttackKnockback { get => cardAttackKnockback; set => cardAttackKnockback = value; }
    public string CharacterUsed { get => characterUsed; set => characterUsed = value; }
    public string CardSubType { get => cardSubType; set => cardSubType = value; }
    public string CardHazardRange { get => cardHazardRange; set => cardHazardRange = value; }
    public string Effect { get => effect; set => effect = value; }
    public string Trigger { get => trigger; set => trigger = value; }
    public string Location { get => location; set => location = value; }
    public int CardCost { get => cardCost; set => cardCost = value; }

    public string showCard()
    {
        return "[Name: " + CardName + "]\n"+ "[Cost: " + CardCost + "]\n"+"[Type: " + CardType + "]\n" + "[Desc: " + CardDescription + "]\n" + 
        "[Range: " + CardAttackRange + "]\n" + "[DMG: " + CardAttackDamage + "]\n" + "[KB: " + CardAttackKnockback+ "]\n" + 
        "[AtkType: " + CardSubType + "]\n"+ "[Character: " + CharacterUsed + "]\n" + "[HazardRange: " + CardHazardRange + "]\n";
    }
}
