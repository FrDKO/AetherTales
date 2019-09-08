using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArtLoader : MonoBehaviour
{
    Object[] AllArt;
    public List<Sprite> artImages;

    // Start is called before the first frame update
    void Start()
    {
        AllArt = Resources.LoadAll("CardArt") as Object[];
        Convert();
    }

    void Convert()
    {
        foreach(Object x in AllArt)
        {
            if(x.GetType() == typeof(UnityEngine.Texture2D))
            {
                Texture2D tex = x as Texture2D;
                Sprite p =  Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), Vector2.zero);
                p.name = x.name;
                artImages.Add(p);
            }
        }
    }
    public Sprite getArt(string cardName)
    {   
        foreach(Sprite s in artImages)
        {
            if(s.name == cardName)
                return s;
        }
        return null;

    }
}

