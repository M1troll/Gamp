using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WayArray : MonoBehaviour
{
    public GameObject Obj;
    public int ClassNumber;
    public Vector3 StartPosotion;
    public GameObject NextCamera;
    
    public List<GameObject> SelectedWay;
    public List<GameObject> AllArrows;
    public List<GameObject> WaysUp;
    public List<GameObject> Ways_1;
    public List<GameObject> Ways_2;

    //bool check = false;
    [SerializeField]
    GameObject _secondCamera;

    void Start()
    {
        StartPosotion = Obj.transform.position;
        //check = true;
    }

    void FixedUpdate()
    {
        if (ClassNumber > 100) {
            if (ClassNumber > 200)
            {
                WaysUp.Mask(true);
            }
            else if (ClassNumber > 115)
            {
                Ways_2.Mask(true);
            }
            else if (ClassNumber <= 115)
            {
                Ways_1.Mask(true);
            }
        }
    }
}

public static class Bonus
{
    public static void Mask(this List<GameObject> list,bool Set)
    {
        foreach (GameObject gameObject in list)
        {
            gameObject.SetActive(Set);
        }
    } 
}


