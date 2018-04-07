using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveScript : MonoBehaviour {

    public Transform enemyPos;

    public float minX;

    public float maxX;

    public float distance;

    public float difficulty;

    bool forward;

	// Use this for initialization
	void Start () {

        //randomize direction
        int i = Random.Range(1, 3);

        if (i == 1)
        {
            forward = true;
        }
        else
        {
            forward = false;
        }
		
	}
	
	// Update is called once per frame
	void Update () {

        if(forward == true)
        {
            //move enemy forward
            float enemyX = enemyPos.position.x;
            float enemyY = enemyPos.position.y;

            enemyX = enemyX + (distance * difficulty * Time.deltaTime);

            this.transform.position = new Vector3(enemyX, enemyY, 0);

        }
        else if(forward == false)
        {
            //move enemy backward
            float enemyX = enemyPos.position.x;
            float enemyY = enemyPos.position.y;

            enemyX = enemyX - (distance * difficulty * Time.deltaTime);

            this.transform.position = new Vector3(enemyX, enemyY, 0);
        }

        if (enemyPos.position.x <= minX)
        {
            forward = true;
        }

        if (enemyPos.position.x >= maxX)
        {
            forward = false;
        }
		
	}
}
