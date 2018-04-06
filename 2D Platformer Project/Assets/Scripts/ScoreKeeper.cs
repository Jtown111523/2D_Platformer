using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public float diamonds;

    public float deaths;

    public Text diamondText;

    public Text deathText;

    public static ScoreKeeper instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }


    // Update is called once per frame
    void Update () {

        diamondText.text = "Diamonds: " + diamonds.ToString("0");

        deathText.text = "Deaths: " + deaths.ToString("0");
        
		
	}
}
