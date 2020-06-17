using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WayArray : MonoBehaviour
{
    public GameObject Obj;
    public int ClassNumber;
    public List<GameObject> AllArrows;
    public List<GameObject> WaysUp;
    public List<GameObject> Ways_1;
    public List<GameObject> Ways_2;
    //bool check = false;
    
    void Start()
    {
        //check = true;
    }

    void FixedUpdate()
    {
        if (ClassNumber > 100) {
            if (ClassNumber > 200)
            {
                AllArrows.Mask(false);
                WaysUp.Mask(true);
            }
            else if (ClassNumber > 115)
            {
                AllArrows.Mask(false);
                Ways_2.Mask(true);
            }
            else if (ClassNumber <= 115)
            {
                AllArrows.Mask(false);
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


