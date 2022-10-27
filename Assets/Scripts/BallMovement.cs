using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D BallRB;
    public Collider2D collide;


    void Start()
    {
        float y = 300;
        float x = 0;
        if(Random.Range(-1,1) == 0)
            x = Random.Range(100,300);
        else
            x = Random.Range(-300,-100);
        if(Random.Range(-1,1)==0)
            y = 300*Mathf.Sin(Mathf.Acos(x/300));
        else
            y = -1*(300*Mathf.Sin(Mathf.Acos(x/300)));
       



        BallRB.AddForce(new Vector2(x, y));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
