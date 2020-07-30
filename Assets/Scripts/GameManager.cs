using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool endgame = false;
    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;
 
    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
        Invoke("Restart",4f);
    }

    public void Endgame()
    {

        if (endgame == false)
        {
            endgame = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
