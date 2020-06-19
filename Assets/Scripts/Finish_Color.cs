using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Color : MonoBehaviour
{
    public GameObject thisObj;

    Color _color;
    void Start()
    {
        _color = thisObj.GetComponent<Renderer>().material.color;   
    }

    void OnMouseDown()
    {
        thisObj.SetActive(false);
    }

    void OnMouseEnter()
    {
        thisObj.GetComponent<Renderer>().material.color = new Color(255, 165, 0);
    }

    void OnMouseExit()
    {
        thisObj.GetComponent<Renderer>().material.color = _color; 
    }
}
