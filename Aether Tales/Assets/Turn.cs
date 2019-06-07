using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    //This design is for the front end right now. 
    
    int realTimer;
    int phase = 0; //Skips start players draw phase
    public void Start()
    {
        pause(5);
    }
    

    public void switchTurn()
    {
       //Show title tag for switched players
       Debug.Log("Turn Switch");
       pause(2);
    }
    public void drawPhase()
    {
        Debug.Log("Draw Phase");
        pause(4);

        //Show appropriate title tag
        //Draw a card animation
        //Check for secondary effects
    }

    public void standByPhase()
    {
        Debug.Log("Standby Phase");
        pause(3);
        //Show appropriate title tag
        //Check for secondary effects
    }

    public void mainPhase()
    {
        Debug.Log("Main Phase");
        pause(8);
        //Show appropriate title tag
        //check for secondary effects
        //Have some pause time not too much
        //IF an attack hits, don't go into blitz phase
    }

    public void blitzPhase()
    {
        Debug.Log("Blitz Phase");
        pause(5);
        //Show appropriate title tag
        //check for secondary effects
        //Cycle through this phase as long as the user can place cards
    }

    public void endPhase()
    {
        Debug.Log("End Phase");
        pause(2);
        //Show appropriate title tag
        //check for secondary effects
        //Check for Hand Limit on current player
    }


    public void pause(int timeInSeconds)
    {
        realTimer = timeInSeconds;
        Debug.Log("in Pause" + realTimer);
        StartCoroutine("cyclePhases");
        
    }

    
    IEnumerator cyclePhases()
    {
        Debug.Log("started cycle");
        yield return new WaitForSeconds(realTimer);
        if(phase > 4) phase = -1;
        switch(++phase)
        {
            case 0: drawPhase(); break;
            case 1: standByPhase(); break;
            case 2: mainPhase(); break;
            case 3: blitzPhase(); break;
            case 4: endPhase(); break;
            case 5: switchTurn(); break;
            
        }
    }
}
