using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public Text deathText;

    public Text diamondText;

    [HideInInspector]
    public float diamonds;
    [HideInInspector]
    public float deaths;



	// Use this for initialization
	void Start () {

        diamonds = 0;

        deaths = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

        deathText.text = "Deaths: " + deaths.ToString("0");

        diamondText.text = "Diamonds: " + diamonds.ToString("0");
		
	}
}
