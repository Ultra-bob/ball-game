using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool fading;
    private Fade fade;
    public Transform reset;

    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<Fade>();
    }

    // Update is called once per frame
    public void Restart()
    {
        reset.position = Vector2.zero;
        Debug.Log("You Died!");
        PlayerPrefs.SetInt("Gems",PlayerPrefs.GetInt("Gems") - 1);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadNextScene()
    {
        fading = true;
        fade.FadeOut();
        Invoke("NextLevel", 1);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadOpenWorld()
    {
        SceneManager.LoadScene(1);
    }

    public void ContinueGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Level"));
    }
}
