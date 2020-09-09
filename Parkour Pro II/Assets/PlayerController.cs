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

        if(transform.position.y > 7 && transform.position.y < 7.5)
        {
            rb.AddRelativeForce(new Vector2(0,100), ForceMode2D.Impulse);
            Debug.Log("Force Applied");
        }

    }

    private void Update()
    {
        if(transform.position.y > 8)
        {
            rb.gravityScale = 5;
        }
        else
        {
            rb.gravityScale = 1.5f;
        }

    }
}
