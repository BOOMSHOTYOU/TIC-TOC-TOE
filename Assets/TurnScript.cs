using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnScript : MonoBehaviour
{
    GameObject gameBoard;
    SpriteRenderer spriteRenderer;
    public Sprite[] images;
    bool unplayed = true;

    //start token with null
    private void Start()
    {
        spriteRenderer.sprite = null;
    }

    //change x to o 
        private void OnMouseDown()
    {
        if (unplayed)
        {
            int index = gameBoard.GetComponent<Game_Script>().TurnPlayer();// running our script of turn
            spriteRenderer.sprite = images[index]; // O or X
            unplayed = false;
        }

    }
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameBoard = GameObject.Find("gameboard");
    }
}
