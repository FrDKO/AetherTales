using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
   List<GameObject> children;



   public void NextMenu(Button b)
   {
       string key = b.name.Replace("Bttn","");
       foreach(GameObject x in children)
       {
           if(x.tag.Equals(key))
           {
               x.SetActive(true);
               x.GetComponent<MenuButton>();
           }
       }
   }


   public void Start()
   {
       getChildren();
   }

   public void getChildren()
   {
       for(int i = 0; i<this.transform.childCount;i++)
       {
           children.Add(this.transform.GetChild(i).gameObject);
       }
   }
}
