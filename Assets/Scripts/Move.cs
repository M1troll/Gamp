using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject obj;
<<<<<<< HEAD
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
=======
    // public float Size = 0.15f;
    public float turnSpeed = 80f, movespeed = 9f;
    void Update()
    {
       // float xPos = Input.GetAxis("Horizontal") * Size;
       // float zPos = Input.GetAxis("Vertical") * Size;
       // obj.transform.position = new Vector3(obj.transform.position.x+xPos, obj.transform.position.y, obj.transform.position.z+zPos);
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
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            obj.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
>>>>>>> 6aca2f029ea9d18193333e195cf7db15150c61a5
        }
    }
}
