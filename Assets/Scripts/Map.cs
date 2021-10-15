using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Map : MonoBehaviour
{
    public static Map Instance;
    public Unit[,] fullMap;

    // Start is called before the first frame update
    void Start()
    {

        fullMap = new Unit[GameManager.Instance.presentMode.mapHeight, GameManager.Instance.presentMode.mapLength];

    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void Initial()
    {
        List<Unit> units = GetComponentsInChildren<Unit>().ToList();
        int h = fullMap.GetLength(0);
        int l = fullMap.GetLength(1);
        for(int i=0; i<h;i++)
        {
            for(int j=0;j<l;j++)
            {
                var newUnit = units[i * h + j];
                newUnit.height = i;
                newUnit.length = j;
                fullMap[i, j] = newUnit;
            }
        }

    }
}
