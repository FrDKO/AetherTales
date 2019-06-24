using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Shuffler<T>
{
    public static List<T> shuffle(List<T> list)
    {
        for(int i = 0; i<list.Count;i++)
        {
            int x = Random.Range(0,list.Count);
            T temp = list[i];
            list[i] = list[x];
            list[x] = temp;
        }
        return list;
    }
    
}
