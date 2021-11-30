using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] Rigidbody2D player;
    [SerializeField] float speed; 
    void Start()
    {
        player.velocity=new Vector2(-10.91f,0);
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.W)){
            transform.Translate(0f,speed*Time.deltaTime,0f);
        }
        if(Input.GetKey(KeyCode.S)){
            transform.Translate(0f,-speed*Time.deltaTime,0f);
        }
       
    }
}
