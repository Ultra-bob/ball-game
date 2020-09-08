using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    // Update is called once per frame

    private Fade fade;
    private GameManager mgr;

    void Start()
    {
        fade = GetComponentInChildren<Fade>();
        mgr = FindObjectOfType<GameManager>();
    }




    void OnTriggerEnter2D()
    {
        mgr.NextLevel();
    }



  
}
