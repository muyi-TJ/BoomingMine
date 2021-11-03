using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mode
{
    public readonly int mapHeight;
    public readonly int mapLength;
    public readonly int mineNum;
    public double jumpTime;

    protected Mode(int h,int l,int num,double time)
    {
        mapHeight = h;
        mapLength = l;
        mineNum = num;
        jumpTime = time;
    }
}
