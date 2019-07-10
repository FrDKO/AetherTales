using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Card: ScriptableObject
{
    Activator activator = new Activator();
    public  string CardName;
    public string CardType;
    public string CardDescription;
    public int CardAttackRange;
    public int CardAttackDamage;
    public int CardAttackKnockback;
    public string CharacterUsed;
    public string CardSubType;

    public string CardHazardRange;
    public string  Effect;
    public string Trigger;
    public string Location;
    public int CardCost;
    public Sprite CardImage;
    public bool IsFlipped = false;

    public string showCard()
    {
        return "[Name: " + CardName + "]\n"+ "[Cost: " + CardCost + "]\n"+"[Type: " + CardType + "]\n" + "[Desc: " + CardDescription + "]\n" + 
        "[Range: " + CardAttackRange + "]\n" + "[DMG: " + CardAttackDamage + "]\n" + "[KB: " + CardAttackKnockback+ "]\n" + 
        "[AtkType: " + CardSubType + "]\n"+ "[Character: " + CharacterUsed + "]\n" + "[HazardRange: " + CardHazardRange + "]\n";
    }
    public void activate()
    {
        activator.run(this);
    }
}
