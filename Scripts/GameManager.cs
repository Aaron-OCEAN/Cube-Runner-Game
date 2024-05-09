using UnityEngine.SceneManagement; 
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 2f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
    
    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            Debug.Log("GAME OVER");
            gameHasEnded = true;
            // restart game
            Invoke("Restart", restartDelay);
        }
        
    }
    
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
