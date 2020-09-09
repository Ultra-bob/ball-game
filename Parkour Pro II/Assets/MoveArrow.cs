using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public Transform follow;
    private Vector2 followpos;
    private SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        followpos.y = 6.5f;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        followpos.x = follow.position.x;
        transform.position = followpos;
        //TODO: hide arrow if the player isnt on screen
        if(follow.position.y > 7)
        {
            sr.enabled = true;
        }
        else
        {
            sr.enabled = false;
        }
    }
}
