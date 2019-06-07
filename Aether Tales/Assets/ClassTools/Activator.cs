using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator
{
    bool isPreparing = false;
    List<Card> prepList = new List<Card>();
    /*
        User stories:
        goal - 
        Create a generic list of effects (simple)
        that can be utilized by more difficult effects
        basically, if a card needs to be discarded, a non-specific card, a specific type of card, 
        or a specific named card can all run the same method. 
     */
    /* Potential list of effects: 
    --------------Activation Types------------------
    While in hand
    While in abyss
    While in dropZone
    While a flipped platform
    //////////////////////////////////////
    When Drawn
    //////////////////////////////////////
    When sent to abyss
    When sent to dropZone
    //////////////////////////////////////
    When another card activates
    //////////////////////////////////////
    When another card enters the dropZone
    When another card enters the abyss
    //////////////////////////////////////
    When a series of cards activate
    //////////////////////////////////////
    When the owner takes damage
    When the owner gets KO'd
    When the owner is on the ledge
    When the owner is moved
    //////////////////////////////////////
    When a platform is flipped
    //////////////////////////////////////
    --------------Moving cards arounnd--------------
    Keep face up
    Keep face down
    //////////////////////////////////////
    Placing a platform from your hand
    Placing a platform from your abyss
    Placing a platform from your dropZone
    Placing a platform from your deck
    //////////////////////////////////////
    Moving a platform 
    //////////////////////////////////////
    Sending a platform to the hand
    Sending a platform to the abyss
    Sending a platform to the dropZone
    Sending a platform to the deck
    //////////////////////////////////////
    Adding a searched card to your hand
    Adding a searched card to your abyss
    Adding a searched card to your dropZone
    //////////////////////////////////////
    Discarding a card from your hand to the abyss
    //////////////////////////////////////
    Putting a card from your hand to the DropZone
    Putting a card from your hand to the Top/Bottom of the Deck
    Putting a card from your hand to the middle of the Deck
    ---------------Player Game interactions----------
    Dealing Damage
    Dealing variable Damage
    Dealing Knockback
    Dealing variable Knockback
    //////////////////////////////////////
    Moving a player on the Stage
    Moving and then allowing the player to play an attack
    //////////////////////////////////////
    Player Attack (Range in calculation)
    ------------------------------------
    Assume that this applies to either player as well, and have a way to show that the other player is effected
    by this card. 
    Possible implementations: 
    If we have the user as an argument for run, then we can use it in effects
     */
    public void run(Card card)
    {
        string[] actionList = card.Effect.Split(',');
        for(int i = 0; i<actionList.Length;i++)
        {
            switch(actionList[i].ToLower())
            {
                case "draw":  break;
            }
        }
    }
//Generic Methods for simple implementation
    private void draw(int amount)
    {
    
    }
}
