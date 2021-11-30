using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
   [SerializeField] float speed; 
   [SerializeField] Rigidbody2D player;
    void Start(){
        player.velocity=new Vector2(10.91f,0);
    }
    void Update(){
         if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0f,speed*Time.deltaTime,0f);
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0f,-speed*Time.deltaTime,0f);
        }
    }
}
