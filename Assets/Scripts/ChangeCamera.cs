using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    public WayArray wayArray;
    public GameObject StartCamera;
    
    void Start(){}

    void Update(){}

    void OnMouseDown()
    {
        StartCamera.GetComponent<WayArray>().NextCamera.SetActive(true);
        StartCamera.transform.position = StartCamera.GetComponent<WayArray>().StartPosotion;
        StartCamera.SetActive(false);
    }
}
