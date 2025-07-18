using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfGameMenuController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 

    public void exitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}
