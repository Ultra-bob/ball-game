using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrow : MonoBehaviour
{
    public Transform follow;
    private Vector2 followpos;

    // Start is called before the first frame update
    void Start()
    {
        followpos.y = 6.5f;
    }

    // Update is called once per frame
    void Update()
    {
        followpos.x = follow.position.x;
        transform.position = followpos;
        //hide arrow if the player isnt on screen
        if(follow.position.y > 7)
        {

        }
    }
}
