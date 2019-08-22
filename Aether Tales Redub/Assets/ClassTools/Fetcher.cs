using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.IO;
public class Fetcher
{
    private string FolderPath;

    public void setPath(string path)
    {
        FolderPath = path;
    }
    public Sprite LoadSprite(string name)
    {
        return Resources.Load<Sprite>(FolderPath+"/"+name);
    }

    public Image LoadImage(string name)
    {
        return Resources.Load<Image>(FolderPath+"/"+name);
    }

    public TextAsset LoadText(string name)
    {
        return Resources.Load<TextAsset>(FolderPath+"/"+name);
    }

    public Card LoadCard(string name)
    {
        return Resources.Load<Card>(FolderPath+"/"+name);
    }

    public Image LoadFromPath(string FullPath, string name)
    {
        return Resources.Load<Image>(FullPath+"/"+name);
    }

    

}
