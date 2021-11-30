using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    [SerializeField] Rigidbody2D ballrigidbody;
    Vector3 move = Vector3.zero;
    float speed = 4.0f;
    void Start()
    {

    }
    void Update()
    {
        float d = ballrigidbody.position.y - transform.position.y;
        if (d > 0){
            move.y = speed * Mathf.Min(d, 1.0f);
        }
        if (d < 0){
            move.y = -(speed * Mathf.Min(-d, 1.0f));
        }
        transform.position += move * Time.deltaTime;
    }
     
}
