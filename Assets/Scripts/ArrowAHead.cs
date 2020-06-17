using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAHead : MonoBehaviour
{
    public GameObject thisObj;
    public GameObject obj;
    public GameObject NextPoint;

    bool check = false;
    public float step = 5f;

    void OnMouseDown()
    {
        check = true;
    }

    void Update()
    {
        if(Vector3.Distance(obj.transform.position, NextPoint.transform.position) > 0.1f&&check==true)
        {
            obj.transform.position = Vector3.Lerp(obj.transform.position, NextPoint.transform.position, step * Time.deltaTime);
        }
        else if(Vector3.Distance(obj.transform.position, NextPoint.transform.position) <= 0.1f)
        {
            check = false;
            thisObj.SetActive(false);
        }
    }

}
