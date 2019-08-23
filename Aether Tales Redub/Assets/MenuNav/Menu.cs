using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
public string baseTag;
string currentMenuName;

List<string> sectionList = new List<string>();
public void Start()
{
    openMenu(baseTag);
}

void OnEnable()
{
    openMenu(baseTag);
}
   public void openSection(Dropdown dropdown)
   {

       string sectionName = dropdown.options[dropdown.value].text;
    if(!sectionName.Equals("Card Type"))
    {
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
   }
   public void openMenu(string menuName)
   {
       try
       {
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
       catch
       {
           //Do nothing
       }
   }
   public void openSection(string sectionName)
   {
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
   public void addToList(string item)
   {
       sectionList.Add(item);
   }
   public void resetList()
   {
       sectionList.Clear();
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
