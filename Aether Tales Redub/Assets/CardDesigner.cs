using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
public class CardDesigner : MonoBehaviour
{

    public CardDisplay cardModel;
    Card card;
   
   //Card cannot have the attributes "unlisted"
    public void Start()
    {
         card = (Card)ScriptableObject.CreateInstance("Card");
    }

    public void UpdateName(InputField inputField)
    {
        card.CardName = inputField.text;
        cardModel.setCardName(inputField.text);
    }
    public void UpdateType(Text dropdownText)
    { 
        card.CardType = dropdownText.text;
        cardModel.setCardtype(dropdownText.text);
        Debug.Log("Current type is: " + dropdownText.text);
        makeCardValid(card.CardType);
    }
    public void UpdateDescription(InputField inputField)
    {
        card.CardDescription = inputField.text;
        cardModel.setDescriptionText(inputField.text);
    }
    public void UpdateCost(Slider slider)
    {
        card.CardCost = (int)slider.GetComponent<Slider>().value;
        cardModel.setCostSprite(card.CardCost.ToString());
    }

    //Take this selection as Text and parse it so it can be used that way
    public void UpdateUseBy(Text dropdownText)
    {
       card.CharacterUsed = dropdownText.text;
       cardModel.setUsedBySprite(dropdownText.text);
    }

    public void UpdateSubType(Text subTypeText)
    {
        if(!subTypeText.text.Contains("Type"))
        {
        card.CardSubType = subTypeText.text;
        cardModel.setSubType(subTypeText.text);
        }
    }
    public void UpdateDamage(Slider slider)
    {
        card.CardAttackDamage =  (int)slider.GetComponent<Slider>().value;
        cardModel.setDamageSprite(card.CardAttackDamage.ToString());
    }
    public void UpdateKnockback(Slider slider)
    {
        card.CardAttackKnockback =  (int)slider.GetComponent<Slider>().value;
        cardModel.setKnockbackSprite(card.CardAttackKnockback.ToString());
    }
    
    public void UpdateRange(Slider slider)
    {
        card.CardAttackRange =  (int)slider.GetComponent<Slider>().value;
        cardModel.setRangeSprite(card.CardAttackRange.ToString());
    }
    public void UpdateHazardRange(Text hazardRange)
    {
        card.CardHazardRange = hazardRange.text;
        cardModel.setHazardRangeSprite(hazardRange.text);
    }
    public void saveCard()
    {
        StartCoroutine(getScreenshot());
        ScriptableObjectUtility SOU = new ScriptableObjectUtility();
        SOU.CreateAsset<Card>(card);
        card = (Card)ScriptableObject.CreateInstance("Card");
    }
    public void makeCardValid(string type)
    {
        if(type.Equals("Attack"))
        {
            card.CardHazardRange = "";
        }
        else if(type.Equals("Hazard"))
        {
            card.CardAttackDamage = 0;
            card.CardAttackKnockback = 0;
            card.CardAttackRange = 0;
        }
        else
        {
            card.CardAttackDamage = 0;
            card.CardAttackKnockback = 0;
            card.CardAttackRange = 0; 
            card.CardHazardRange = "";
        }
    }
    RectTransform rectT;
    int width;
    int height;

    public IEnumerator getScreenshot()
    {
        yield return new WaitForEndOfFrame();
        rectT = cardModel.gameObject.GetComponent<RectTransform>();
        width = System.Convert.ToInt32(rectT.rect.width);
        height = System.Convert.ToInt32(rectT.rect.height);

        Vector2 temp = rectT.transform.position;
        var startX = temp.x - width/2;
        var startY = temp.y - height/2;
        var tex = new Texture2D (width,height,TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(startX,startY,width,height),0,0);
        tex.Apply();

        Sprite cardSprite = Sprite.Create(tex,new Rect(0,0,width,height),new Vector2(0,0));
        card.CardImage = cardSprite;
        
        var bytes = tex.EncodeToPNG();
        Destroy(tex);

        File.WriteAllBytes(Application.dataPath + card.CardName+".png",bytes);
    }
}
