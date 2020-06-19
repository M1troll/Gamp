using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WayArray : MonoBehaviour
{
    public GameObject Obj;
    public int ClassNumber;
<<<<<<< HEAD
    public Vector3 StartPosotion;
    public GameObject NextCamera;
    
    public List<GameObject> SelectedWay;
=======
>>>>>>> 6aca2f029ea9d18193333e195cf7db15150c61a5
    public List<GameObject> AllArrows;
    public List<GameObject> WaysUp;
    public List<GameObject> Ways_1;
    public List<GameObject> Ways_2;
<<<<<<< HEAD

    //bool check = false;
    [SerializeField]
    GameObject _secondCamera;

    void Start()
    {
        StartPosotion = Obj.transform.position;
=======
    //bool check = false;
    
    void Start()
    {
>>>>>>> 6aca2f029ea9d18193333e195cf7db15150c61a5
        //check = true;
    }

    void FixedUpdate()
    {
        if (ClassNumber > 100) {
            if (ClassNumber > 200)
            {
<<<<<<< HEAD
=======
                AllArrows.Mask(false);
>>>>>>> 6aca2f029ea9d18193333e195cf7db15150c61a5
                WaysUp.Mask(true);
            }
            else if (ClassNumber > 115)
            {
<<<<<<< HEAD
=======
                AllArrows.Mask(false);
>>>>>>> 6aca2f029ea9d18193333e195cf7db15150c61a5
                Ways_2.Mask(true);
            }
            else if (ClassNumber <= 115)
            {
<<<<<<< HEAD
=======
                AllArrows.Mask(false);
>>>>>>> 6aca2f029ea9d18193333e195cf7db15150c61a5
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


