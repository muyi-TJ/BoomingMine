using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Generator : MonoBehaviour
{
    int maxBoom = 0;

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
        var units = ToList(Map.Instance.fullMap);
        units = units.OrderBy(c => Guid.NewGuid()).ToList();
        for(int i=0;i<maxBoom;i++)
        {
            units[i].SetToBoom();
        }
        for(int i=maxBoom;i<units.Count;i++)
        {
            units[i].SetToNumber();
        }

    }

    private List<Unit> ToList(Unit[,] map)
    {
        Unit[] units = new Unit[map.Length];
        int i = 0;
        foreach(var unit in map)
        {
            units[i++] = unit;
        }
        return units.ToList();
    }
}
