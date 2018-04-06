using UnityEngine;

public class AddDiamond : MonoBehaviour {

    public GameObject diamond;

    private void OnTriggerEnter2D()
    {
        //add to Diamond Count

        FindObjectOfType<ScoreKeeper>().diamonds++;

        //destroy object

        DestroyObject(diamond);

    }


}
