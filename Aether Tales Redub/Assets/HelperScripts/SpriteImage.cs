using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteImage : MonoBehaviour
{
   
   public List<Sprite> spriteList;
   public string defaultSprite;
   public void OnEnable()
   {
       setToDefault();
   }
   
   public void setToDefault()
   {
       setSprite(defaultSprite);
   }
   public void setSprite(string spriteName)
   {
        foreach(Sprite sprite in spriteList)
        {
            if(sprite.name.Equals(spriteName))
                this.GetComponent<Image>().sprite = sprite;
        }
   }

   public void setSprite(Text spriteName)
   {
        foreach(Sprite sprite in spriteList)
        {
            if(sprite.name.Equals(spriteName.text))
                this.GetComponent<Image>().sprite = sprite;
        }
   }

    public void Deactivate()
    {
        this.gameObject.SetActive(false);
    }
    public void Activate()
    {
        this.gameObject.SetActive(true);
    }
}
