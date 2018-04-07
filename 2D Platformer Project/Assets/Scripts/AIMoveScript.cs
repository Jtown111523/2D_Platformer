using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMoveScript : MonoBehaviour {

    private Vector3 floorPos;

    private Vector3 scale;

    Vector3 enemyPos;

    float scaleDist;

    Vector3 offset;

    public float distance;

    public float speed;

    bool forward;

    bool pause = false;

    private void OnCollisionEnter2D(Collision2D col)

    {
        if(col.collider.tag == "Floor")
        {
            floorPos = col.gameObject.GetComponent<Transform>().position;
            scale = col.gameObject.GetComponent<Transform>().localScale;
        }

        offset = this.gameObject.GetComponent<Transform>().localScale;

        //start enemy in middle
        enemyPos = new Vector3(floorPos.x, (floorPos.y + (floorPos.y / 2)), 0);

        this.transform.position = enemyPos;

        //make starting direction random

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

        if(pause == false)
        {
            //wait to get data
            StartCoroutine(WaitForData());
            pause = true;
        }

        if(enemyPos.x <= (floorPos.x - (scale.x/2) + offset.x))
        {
            forward = true; 
        }
        if(enemyPos.x >= (floorPos.x + (scale.x/2) - offset.x))
        {
            forward = false;
        }

        if(forward == true)
        {
            //move player forward
            enemyPos.x = enemyPos.x + (distance * speed * Time.deltaTime);
        }
        else if(forward == false)
        {
            //move player backward
            enemyPos.x = enemyPos.x - (distance * speed * Time.deltaTime);
        }

        enemyPos.y = floorPos.y + (offset.y/2);

        this.transform.position = enemyPos;
		
	}
    IEnumerator WaitForData()
    {
        yield return new WaitForSeconds(1);
    }
}
