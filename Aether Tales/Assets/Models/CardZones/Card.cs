using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] 
public class Card 
{
    Activator activator = new Activator();
    private string cardName;
    private string cardType;
    private string effect;
    private string trigger;
    private string location;
    private int cost;
    private User user;
    private bool isFlipped = false;

    public string CardName { get => cardName; set => cardName = value; }
    public string CardType { get => cardType; set => cardType = value; }
    public string Effect { get => effect; set => effect = value; }
    public string Trigger { get => trigger; set => trigger = value; }
    public string Location { get => location; set => location = value; }
    public int Cost { get => cost; set => cost = value; }
    public User User { get => user; set => user = value; }
    public bool IsFlipped { get => isFlipped; set => isFlipped = value; }

    public void activate()
    {
        IsFlipped = true;
        activator.run(this);
    }
}
