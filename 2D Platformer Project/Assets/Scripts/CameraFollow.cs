using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform cameraLoc;

    Transform player;

    public Vector3 offset;

	// Use this for initialization
	void Start () {

        player = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

        cameraLoc.position = player.position + offset;

        cameraLoc.transform.position = cameraLoc.position;

		
	}
}
