using UnityEngine;

public class PlayerMoveScript : MonoBehaviour {

    Transform player;

    public float distance;

    public float speed;

	// Use this for initialization
	void Start () {

        player = GetComponent<Transform>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //move player right
            float playerX = player.position.x;
            float playerY = player.position.y;

            playerX = playerX + (distance * speed * Time.deltaTime);

            this.transform.position = new Vector3(playerX, playerY, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //move player left
            float playerX = player.position.x;
            float playerY = player.position.y;

            playerX = playerX - (distance * speed * Time.deltaTime);

            this.transform.position = new Vector3(playerX, playerY, 0);
        }
		
	}
}
