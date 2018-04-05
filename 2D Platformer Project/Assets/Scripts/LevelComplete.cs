using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour {

    public Transform player;

    public float minDist;

    bool playerHasLost = false;


    private void OnTriggerEnter2D()
    {
        //player completes level
        Debug.Log("Player wins");
        //send player to next level
        Debug.Log("Send Player to next level");
    }
    void Update () {

        if(player.position.y < minDist && playerHasLost == false)
        {
            //end game player loses
            Debug.Log("Player loses");
            playerHasLost = true;
            //restart level
        }
		
	}
}
