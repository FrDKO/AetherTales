using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteImage : MonoBehaviour
{
   public Sprite[] spriteList;

   public string defaultImage;
   public void Start()
   {
       defaultSprites();
   }

   private void defaultSprites()
   {
       if(defaultImage.Length < 2)
       this.GetComponent<Image>().sprite = spriteList[0];
       else
       setSprite(defaultImage);
   }
   public void setSprite(string spriteName)
   {
       foreach(Sprite s in spriteList)
       if(s.name.Equals(spriteName))
       this.GetComponent<Image>().sprite = s;
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
