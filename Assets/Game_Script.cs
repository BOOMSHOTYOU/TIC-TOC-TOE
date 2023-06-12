using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Script : MonoBehaviour
{
    //Game Tracking

    int sprite_Index = -1;

    public int TurnPlayer()
    {
        sprite_Index++;
        return sprite_Index % 2; //remain
    }


}
