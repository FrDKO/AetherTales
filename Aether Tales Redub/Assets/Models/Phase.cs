using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  Phase
{
    string PhaseName;

    public Phase()
    {
        PhaseName = this.GetType().Name;
    }
}
