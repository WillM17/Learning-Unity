using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform playerTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow) && playerTransform.position.y<9)
            playerTransform.Translate(new Vector2(0,0.01f));
        if(Input.GetKey(KeyCode.DownArrow) && playerTransform.position.y>-9)
            playerTransform.Translate(new Vector2(0,-0.01f));
    }
}
