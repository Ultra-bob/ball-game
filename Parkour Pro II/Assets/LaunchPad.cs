using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPad : MonoBehaviour
{
    Rigidbody2D otherRB;
    public float bouncePower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        otherRB = other.GetComponent<Rigidbody2D>();
        otherRB.AddRelativeForce(new Vector2(0, bouncePower));
        Debug.Log("Force Applied!");
    }
}
