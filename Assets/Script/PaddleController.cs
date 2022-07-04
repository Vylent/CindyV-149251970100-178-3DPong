using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed;

    void Start()
    {

    }


    void Update()
    {

       
        MoveObject(GetInput());
        
    }

    private Vector3 GetInput()
    {
        
        if (Input.GetKey(KeyCode.A))
        {
            return Vector3.left * speed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            return Vector3.right * speed;
        }
        return Vector3.zero;
    }

    public void MoveObject(Vector3 movement)
    {
        transform.Translate(movement * Time.deltaTime);
    }

}
