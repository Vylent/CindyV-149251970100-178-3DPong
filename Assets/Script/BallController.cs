using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector3 speed;
    
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate (speed * Time.deltaTime);
    }
}
