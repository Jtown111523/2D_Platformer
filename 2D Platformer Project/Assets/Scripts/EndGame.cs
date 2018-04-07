using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

   public Transform player;

    public PlayerMoveScript playerMoveScript;

    public LevelComplete levelComplete;

	public void playerWin()
    {
        //send to win screen

        //temp send back to start screen for MVP
        SceneManager.LoadScene(0);
    }

    public void playerLose()
    {
        //restart level

        Vector3 playerStartPos = playerMoveScript.playerStartPos;

        player.transform.position = playerStartPos;

        levelComplete.playerHasLost = false;

        FindObjectOfType<ScoreKeeper>().deaths++;

    }
}
