using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject obj;
    public float turnSpeed = 80f, movespeed = 10f;
    
    void Update()
    { if (obj.activeSelf)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                obj.transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                obj.transform.Translate(-Vector3.forward * movespeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                obj.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                obj.transform.Translate(Vector3.up * movespeed * Time.deltaTime);
            }
        }
    }
}
