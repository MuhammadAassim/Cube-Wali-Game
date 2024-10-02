using UnityEngine;

public class End_Trigger : MonoBehaviour
{
    public Game_Manager gamemanager;
    void OnTriggerEnter()
    {
        gamemanager.CompleteLevel();
    }
   
}
