using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SpriteImage : MonoBehaviour
{
   public string path;
   public string DefaultSprite;
   private Fetcher fetcher = new Fetcher();
   public void OnEnable()
   {
       setToDefault();
   }
   public void Awake()
   {
       fetcher.setPath(path);
   }
   
   public void setToDefault()
   {
       this.GetComponent<Image>().sprite = fetcher.LoadSprite(DefaultSprite);
   }
   public void setSprite(string spriteName)
   {
    try
       {
        if(!fetcher.LoadSprite(spriteName).Equals(null))
       this.GetComponent<Image>().sprite = fetcher.LoadSprite(spriteName);
       }
    catch
       {
           Debug.Log("Sprite does not exist");
       }
   }
   public void setSprite(Text spriteName)
   {
      
    try
       {
           if(!fetcher.LoadSprite(spriteName.text).Equals(null))
       this.GetComponent<Image>().sprite = fetcher.LoadSprite(spriteName.text);
       }
    catch
       {
           Debug.Log("Sprite does not exist");
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
