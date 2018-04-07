using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIUpdate : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D col)
    {
        string colTag = col.tag;
        

        if(colTag == "Diamond")
        {
            //add reward to system
            FindObjectOfType<ScoreKeeper>().diamonds++;

            // destroy diamond

            DestroyObject(col.gameObject);


            Debug.Log(col);
        }

        if (colTag == "Enemy")
        {
            // reset player position
            FindObjectOfType<EndGame>().playerLose();
            //add to deaths
            
        }

    }
}
