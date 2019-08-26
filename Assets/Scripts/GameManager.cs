
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject CompleteLevelUI;
    public GameObject LevelFailedUI;
    public float restartDelay = .5f;
    public int Menu = 0;
    public void LevelFailed()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            LevelFailedUI.SetActive(true);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        SceneManager.LoadScene(0);
    }
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);

    }
}
