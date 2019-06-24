using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenu : MonoBehaviour
{

string currentMenuName;
public void Start()
{
    openMenu(gameObject.name.Replace("Menu",""));
}
   public void openSection(Dropdown dropdown)
   {

       string sectionName = dropdown.options[dropdown.value].text;

       foreach(GameObject x in getChildren())
       {
           if(x.CompareTag(sectionName)) //If the menu name matches the tag
           {
               x.SetActive(true);
               x.GetComponent<MenuComponent>().toActive();
           }
           else if(!x.CompareTag(sectionName) && !x.CompareTag(currentMenuName))
           {
               x.GetComponent<MenuComponent>().toRest();
           }
       }
   }
   public void openMenu(string menuName)
   {
       Debug.Log(getChildren().Count);
       currentMenuName = menuName;
       foreach(GameObject x in getChildren())
       {
           if(x.CompareTag(menuName)) //If the menu name matches the current menu name
           {
               x.SetActive(true);
               x.GetComponent<MenuComponent>().toActive();
           }
           else
               x.GetComponent<MenuComponent>().toRest();
       }
   }
  

    public List<GameObject> getChildren()
   {

       List<GameObject> children = new List<GameObject>();
       for(int i = 0; i<this.transform.childCount;i++)
       {
            children.Add(this.transform.GetChild(i).gameObject);
       }
       return children;
   }

}
