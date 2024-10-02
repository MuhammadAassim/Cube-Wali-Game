using UnityEngine;

public class Player_Collision : MonoBehaviour

{
    public Player_Movement mo;
    public Game_Manager gameman;


    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacle")
        {
            mo.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
            gameman.gameOver();
        }
        
    }
}
