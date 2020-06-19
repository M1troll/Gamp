using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowRightRotate : MonoBehaviour
{
    public GameObject thisObj;
    public GameObject obj;

    Quaternion originalRotation;
    float angel;
    bool _check = false;

    void Start()
    {
        originalRotation = obj.transform.rotation;
    }

    void OnMouseDown()
    {
        _check = true;
    }

    void FixedUpdate()
    {
        if (_check && angel < 90)
        {
            angel++;
            Quaternion rotationY = Quaternion.AngleAxis(angel, Vector3.up);
            obj.transform.rotation = originalRotation * rotationY;
        }
        else if (angel == 90)
        {
            _check = false;
            thisObj.SetActive(false);
        }
    }
}
