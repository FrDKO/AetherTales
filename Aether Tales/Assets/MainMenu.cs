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
public void Update()
{
    Debug.Log(currentMenuName);
}
   public void openSection(Dropdown dropdown)
   {

       string sectionName = dropdown.options[dropdown.value].text;

        Debug.Log(sectionName);
       foreach(GameObject x in getChildren())
       {
           if(x.CompareTag(sectionName)) //If the menu name matches the tag
           {
               x.SetActive(true);
               x.GetComponent<MenuOption>().toActive();
           }
           else if(!x.CompareTag(sectionName) && !x.CompareTag(currentMenuName))
           {
               x.GetComponent<MenuOption>().toRest();
           }
       }
   }
   public void openMenu(string menuName)
   {
       currentMenuName = menuName;
       foreach(GameObject x in getChildren())
       {
           if(x.CompareTag(menuName)) //If the menu name matches the tag
           {
               x.SetActive(true);
               x.GetComponent<MenuOption>().toActive();
           }
           else
           {
               x.GetComponent<MenuOption>().toRest();
           }
       }
   }
   public void goBack(string menuName)
   {
       currentMenuName = menuName;
       foreach(GameObject x in getChildren())
       {
           if(x.CompareTag(menuName))
           {
               x.SetActive(true);
               x.GetComponent<MenuOption>().toActive();
           }
           else
           {
               x.GetComponent<MenuOption>().toRest();
           }
       }
   }

    public List<GameObject> getChildren()
   {
       List<GameObject> children = new List<GameObject>();
       Debug.Log(this.transform.childCount);
       for(int i = 0; i<this.transform.childCount;i++)
       {
            children.Add(this.transform.GetChild(i).gameObject);
       }
       return children;
   }

}
