using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CardModelBuilder : MonoBehaviour
{

    public List<SpriteImage> attackImages;
    public List<TextFromInput> texts;

    public List<SpriteImage> genericCardImages;

    public List<SpriteImage> characterCardImages;

    public SpriteImage hazardRangeImage;

    public Image cardArt;
    void OnEnable()
    {
        formatInitialize();
        cardArt.gameObject.SetActive(false);
    }
    public void format(Text typeText)
    {   
        if(!typeText.text.Contains("Type"))
        renderGenericCard();
        if(typeText.text.Equals("Attack"))
        {
           //Debug.Log("Currently Formatting a " + typeText.text);
            formatAttackCard();
        }
        else if(typeText.text.Equals("Hazard"))
        {
            //Debug.Log("Currently Formatting a " + typeText.text);
            formatHazardCard();
        }
        else if(typeText.text.Equals("Character"))
        {
            //Debug.Log("Currently Formatting a " + typeText.text);
            formatCharacterCard();
        }
        else if(typeText.text.Length>0)
        {
            //Debug.Log("Currently Formatting a " + typeText.text);
            formatOtherCard();
        }
        else 
        {
            //Debug.Log("Starting card Builder");
            formatInitialize();
        }
    }
    public void formatInitialize()
    {
        foreach(SpriteImage sprite in attackImages)
        sprite.Deactivate();
        foreach(SpriteImage sprite in characterCardImages)
        sprite.Deactivate();

        foreach(SpriteImage sprite in genericCardImages)
        {
        if(sprite.gameObject.name != "FrontImage")
        sprite.Deactivate();
        }

        hazardRangeImage.Deactivate();

    }

    private void formatAttackCard()
    {
        foreach(SpriteImage sprite in attackImages)
        sprite.Activate();
        
        hazardRangeImage.Deactivate();
    }
    private void formatHazardCard()
    {
        
        foreach(SpriteImage sprite in attackImages)
        sprite.Deactivate();
        hazardRangeImage.Activate();
    }
    private void formatCharacterCard()
    {
        formatInitialize();
    }
private void formatOtherCard()
   {
        TextFromInput subTypeText = texts[1];
        subTypeText.gameObject.GetComponent<Text>().transform.localPosition = new Vector3(-26f,-47f,0);
        hazardRangeImage.Deactivate();
        foreach(SpriteImage sprite in attackImages)
        sprite.Deactivate();
    }
  public void setCosts(Text cardCost)
   {
       //Getting CostImages
       SpriteImage cost1 = genericCardImages[2];
       SpriteImage cost2 = genericCardImages[3];
      
      if(int.Parse(cardCost.text) < 10)
      {
       char val1 = '0'; //The first value
       char val2 = cardCost.text[0]; //The second value
       cost1.setSprite(val1.ToString());
       cost2.setSprite(val2.ToString());
      }
      else if(int.Parse(cardCost.text) % 10 == 0)
      {
          cost1.setSprite(cardCost.text[0].ToString());
          cost2.setSprite("0Full");
      }
      else
      {
          cost1.setSprite(cardCost.text[0].ToString());
          cost2.setSprite(cardCost.text[1].ToString());
      }

       
       
   }   
   public void setDamage(Text cardDamage)
   {
       char val1;
       char val2;
       SpriteImage dmg1 = attackImages[1];
       SpriteImage dmg2 = attackImages[2];
       if(int.Parse(cardDamage.text) < 10)
       {val1 = '0'; val2 = cardDamage.text[0];}
       else
       {val1 = cardDamage.text[0]; val2=cardDamage.text[1];}
       dmg1.setSprite(val1.ToString());
       dmg2.setSprite(val2.ToString());
   }

   private void renderGenericCard()
   {
       //Debug.Log("Generics rendered");
       foreach(SpriteImage sprite in genericCardImages)
        sprite.Activate();
        TextFromInput subTypeText = texts[1];
        subTypeText.gameObject.GetComponent<Text>().transform.localPosition = new Vector3(10.5f,-47f,0);
        foreach(TextFromInput text in texts)
        text.GetComponent<Text>().text = "";

   }
}
