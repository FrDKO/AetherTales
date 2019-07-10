using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public  class CardDataContainer: MonoBehaviour
{
    private string cardName;
    private string cardDescription;
    private string cardType;
    private int cardCost;
    private string attackType;   
    private int attackDamage;
    private int attackKnockback;
    private int attackRange;
    private string validCharacters;

    public void setCardName(GameObject TextInput)
    {
        cardName = TextInput.GetComponent<Text>().text;
    }
    public void setCardDescription(GameObject TextInput)
    {
        cardDescription = TextInput.GetComponent<Text>().text;
    }
    public void setCardType(GameObject Dropdown)
    {
        cardDescription = Dropdown.GetComponent<Dropdown>().options[Dropdown.GetComponent<Dropdown>().value].ToString();
    }
    public void setCardCost(GameObject Slider)
    {
        cardCost = (int)Slider.GetComponent<Slider>().value;
    }
    public void setAttackType(GameObject Dropdown)
    {
        attackType = Dropdown.GetComponent<Dropdown>().options[Dropdown.GetComponent<Dropdown>().value].ToString();
    }
    public void setAttackDamage(GameObject Slider)
    {
        attackDamage = (int)Slider.GetComponent<Slider>().value;
    }
    public void setAttackKnockback(GameObject Slider)
    {
        attackKnockback = (int)Slider.GetComponent<Slider>().value;
    }
    public void setAttackRange(GameObject Slider)
    {
        attackRange = (int)Slider.GetComponent<Slider>().value;
    }
}

