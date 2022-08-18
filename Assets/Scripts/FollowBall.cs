using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour
{
    public Vector3 offset  ;
    public GameObject ball;
    public float lerpRate = 10f;
     public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        offset = ball.transform.position - transform.position;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
       if (!gameOver)
        {
            Follow();
        }
    }


    public void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetPos = ball.transform.position - offset;
        pos =  Vector3.Lerp(pos, targetPos, lerpRate * Time.deltaTime);
        transform.position = pos;
    }
}
