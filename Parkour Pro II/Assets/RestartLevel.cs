using UnityEngine.SceneManagement;
using UnityEngine;

public class RestartLevel : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D()
    {
        //todo: refactor this to call restart instead of reloading scene
        FindObjectOfType<GameManager>().Restart();
    }

}