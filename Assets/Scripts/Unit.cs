using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public bool isNear = false;
    public int nearNum = 0;
    Top top;
    public int height = 0;
    public int length = 0;



    // Start is called before the first frame update
    void Start()
    {
        top = GetComponentInChildren<Top>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
