using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour

{
    bool Game_Has_Ended = false;
    public GameObject completeLevelUI;
    public GameObject gameOverUI;


    public void EndGame()
    {
        if (Game_Has_Ended == false)
        {
            Game_Has_Ended = true;
            Invoke("Restart", 1f);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

}