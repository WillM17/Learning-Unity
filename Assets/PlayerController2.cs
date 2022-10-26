using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform playerTransform2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) && playerTransform2.position.y<9 )
            playerTransform2.Translate(new Vector2(0,0.01f));
        if(Input.GetKey(KeyCode.S) && playerTransform2.position.y>-9)
            playerTransform2.Translate(new Vector2(0,-0.01f));
    }
}
