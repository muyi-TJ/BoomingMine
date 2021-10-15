using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Map Instance;

    public int[,] fullMap;
    // Start is called before the first frame update
    void Start()
    {
        fullMap = new int[GameManager.Instance.presentMode.mapHeight, GameManager.Instance.presentMode.mapLength];
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
