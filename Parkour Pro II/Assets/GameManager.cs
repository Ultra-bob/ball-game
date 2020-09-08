using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool fading;
    private Fade fade;

    // Start is called before the first frame update
    void Start()
    {
        fade = FindObjectOfType<Fade>();
    }

    // Update is called once per frame
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

}
