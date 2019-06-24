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
    public int AttackRange;
    public int AttackDamage;
    public int AttackKnockback;
    public string AttackType;
    public string Effect;
    public string Trigger;
    public string Location;
    public int Cost;
 
    public Sprite artwork;
    public Sprite usedBy;
    public bool IsFlipped = false;

    public string showCard()
    {
        return "[Name: " + CardName + "]\n"+ "[Cost: " + Cost + "]\n"+"[Type: " + CardType + "]\n" + "[Desc: " + CardDescription + "]\n" + 
        "[Range: " + AttackRange + "]\n" + "[DMG: " + AttackDamage + "]\n" + "[KB: " + AttackKnockback+ "]\n" + 
        "[AtkType: " + AttackType + "]\n";
    }
    public void activate()
    {
        activator.run(this);
    }
}
