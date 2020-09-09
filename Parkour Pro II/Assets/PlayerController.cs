﻿using UnityEngine.SceneManagement;
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

<<<<<<< Updated upstream
<<<<<<< Updated upstream
=======
        if(transform.position.y > 7 && transform.position.y < 8)
        {
            //rb.AddRelativeForce(new Vector2(0,1000), ForceMode2D.Impulse);
            //Debug.Log("Force Applied");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
=======
        if(transform.position.y > 7 && transform.position.y < 8)
        {
            //rb.AddRelativeForce(new Vector2(0,1000), ForceMode2D.Impulse);
            //Debug.Log("Force Applied");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
>>>>>>> Stashed changes
            rb.AddRelativeForce(new Vector2(0, 100));
        }

    }

    private void Update()
    {
        if(transform.position.y > 20)
        {
            rb.velocity = new Vector2(rb.velocity.x, -10);
        }
        else
        {
            //rb.gravityScale = 1.5f;
        }

>>>>>>> Stashed changes
    }
}
