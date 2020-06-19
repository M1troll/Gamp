using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextWay : MonoBehaviour
{
    public GameObject oldObj;
    public GameObject obj;
    public List<GameObject> AllArrows;
    public List<GameObject> NewWay;
    [SerializeField]
    private bool _show;
    [SerializeField]
    private int _classNumber;

    void Start(){}

    void Update()
    {
        if (obj.activeSelf)
        {
            _classNumber = oldObj.GetComponent<WayArray>().ClassNumber%100;

        }
    }
}
