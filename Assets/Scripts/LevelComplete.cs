using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour {
    
    public void levelcomplete()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
