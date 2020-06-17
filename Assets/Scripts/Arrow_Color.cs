using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Color : MonoBehaviour
{
    public GameObject thisObj;

    void OnMouseDown()
    {
        //thisObj.SetActive(false);
    }

    void OnMouseEnter()
    {
        thisObj.GetComponent<Renderer>().material.color = new Color(255, 165, 0);
    }

    void OnMouseExit()
    {
        thisObj.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
    }
}
