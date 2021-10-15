using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    int maxBoom = 0;
    int boomRemain = 0;

    // Start is called before the first frame update
    void Start()
    {
        maxBoom = GameManager.Instance.presentMode.mineNum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGenerate()
    {


    }


}
