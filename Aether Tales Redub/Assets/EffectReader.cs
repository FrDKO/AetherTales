using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectReader : MonoBehaviour
{
    Card card;

    public void setCard(Card Card)
    {
        card = Card;
    }

    public void runEffectList()
    {
        //Split them by ;
        //Split them by , (During iteration)
       string[] effectList = card.Effect.Split(';');//Draw:3,Discard:1;Move,1
       for(int i = 0; i<effectList.Length;i++)
       {
           runEffect(effectList[i]);//Still using commas here
       }
    }

    private void runEffect(string effect)
    {
       //Currently we are dealing with 1 effect Draw:3,Discard:1
    }

    private void Draw(int count)
    {

    }

    private void Discard(int count)
    {
        
    }
}
