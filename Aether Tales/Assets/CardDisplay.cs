using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardDisplay : MonoBehaviour
{
    SpriteImage CardTemplate;
    public Text subTypeText;
    public Text nameText;
    public Text DescriptionText;
    public SpriteImage RangeImage;
    public SpriteImage HazardRangeImage;
    public SpriteImage CostImageDigit1;
    public SpriteImage CostImageDigit2;
    public Image cardArt;
    public SpriteImage DamageImageDigit1;
    public SpriteImage DamageImageDigit2;
    public SpriteImage KnockbackImageDigit;
    public SpriteImage UsedBySprite;
    public SpriteImage Background;
    string Type;
    void Start()
    {
        CardTemplate = this.GetComponent<SpriteImage>();
        setCardtype("Attack");
    }
    public void setCardtype(string type)
    {
        Type = type;
        CardTemplate.setSprite(type);
        setSubType("");
        Display();
    }
    public void setCardName(string newCardName) => nameText.text = newCardName;
    public void setSubType(string newSubType)=> subTypeText.text = newSubType;
    public void setDescriptionText(string newDescription)=> DescriptionText.text = newDescription;
    public void setRangeSprite(string newRangeSprite)=> RangeImage.setSprite(newRangeSprite);

    public void setBackground(Text backgroundName)
    {
        Background.setSprite(backgroundName.text);
    }
    public void setHazardRangeSprite(string spriteRange)
    {
        HazardRangeImage.setSprite(spriteRange);
        Display();
    }
    public void setCostSprite(string Cost)
    {
        Debug.Log(Cost);
        if(Cost.Length<2)
        {
            Cost= "0"+Cost;
        }

        CostImageDigit1.setSprite(Cost[0].ToString());
        if(int.Parse(Cost)<10)
        {
            Debug.Log("Cost is " + Cost + " Which is less than 10");
           if(Cost[1] == '0') CostImageDigit2.setSprite(Cost[1].ToString() +  " Empty"); 
           else CostImageDigit2.setSprite(Cost[1].ToString());
        }
        else
        {
        Debug.Log("Cost is " + Cost + " Which is more than 10");
            if(Cost[1]=='0')
                CostImageDigit2.setSprite(Cost[1].ToString()+ " Full");
                else
                CostImageDigit2.setSprite(Cost[1].ToString());
        }
        Display();
    }
    public  void setDamageSprite(string Damage)
    {
        if(Damage.Length < 2)
        {
            Damage = "0"+Damage;
        }    
        DamageImageDigit1.setSprite(Damage[0].ToString());
        DamageImageDigit2.setSprite(Damage[1].ToString());
        Display();
    }
    public void setKnockbackSprite(string Knockback)
    {
        KnockbackImageDigit.setSprite(Knockback);
        Display();
    }
    public void setUsedBySprite(string CharacterName)
    {
        UsedBySprite.setSprite(CharacterName);
        Display();
    }

    public void Display()
    {
        switch(Type)
        {
            case("Attack"):renderElse(); renderAttack(); break;
            case("Hazard"):renderElse(); renderHazard(); break;
            default: renderElse(); break;
        }
    }
    public void renderAttack()
    {
        RangeImage.Activate();
        DamageImageDigit1.Activate();
        DamageImageDigit2.Activate();
        KnockbackImageDigit.Activate();
    }
    public void renderHazard()
    {
        HazardRangeImage.Activate();
    }
    public void renderElse()
    {
        RangeImage.Deactivate();
        DamageImageDigit1.Deactivate();
        DamageImageDigit2.Deactivate();
        KnockbackImageDigit.Deactivate();
        HazardRangeImage.Deactivate();
    }
}
