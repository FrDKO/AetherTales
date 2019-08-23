using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEditor;
public class ArtUpload : MonoBehaviour
{
    public Image cardArtImage;
    public CardDataContainer cardDataContainer;
    Texture2D texture;

    byte[] fileContent;
   public void Search()
   {
      string Path = EditorUtility.OpenFilePanel("Uploading Art","","PNG");
        if (Path.Length != 0)
        {
            //Debug.Log(Path);
            fileContent = File.ReadAllBytes(Path);
            texture = new Texture2D(2,2);
            texture.LoadImage(fileContent,false);
            Sprite cardArt = Sprite.Create(texture,new Rect(0,0,texture.width,texture.height),new Vector2(.5f,.5f));
            cardArtImage.sprite = cardArt;
            cardDataContainer.DeliverArt(texture);
            cardArtImage.gameObject.SetActive(true);
        }
   }

}
