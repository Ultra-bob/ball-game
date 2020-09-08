using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}