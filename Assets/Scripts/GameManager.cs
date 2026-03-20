using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject finishPanel;

    // End the game and show the panel
    public void Finish()
    {
        finishPanel.SetActive(true);
    }
    
    // Restart the level
    public void RestartLevel()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
