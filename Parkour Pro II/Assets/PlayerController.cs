using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    private Vector2 direction;
    public float speed;
    public bool fading;
    private GameManager mgr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mgr = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        direction.y = rb.velocity.y;

        rb.velocity = direction;
        fading = mgr.fading;

        if(transform.position.y < -6 && fading == false)
        {
            mgr.Restart();
        }

    }
}
