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

    public bool isMine = false;

    private List<Unit> near = new List<Unit>();



    // Start is called before the first frame update
    void Start()
    {
        top = GetComponentInChildren<Top>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public List<Unit> GetNear()
    {
        return near;
    }

    public void AddNear(Unit unit)
    {
        unit.near.Add(this);
        this.near.Add(unit);
    }

    public void SetToBoom()
    {
        isMine = true;
        foreach(var unit in near)
        {
            if(unit.isMine)
            {
                continue;
            }
            if(!unit.isNear)
            {
                unit.isNear = true;
            }
            unit.nearNum++;
        }
        this.transform.GetComponent<Renderer>().material = UnitMaterial.mine;
    }

    public void SetToNumber()
    {
        switch(nearNum)
        {
            case 1:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number1;
                break;
            case 2:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number2;
                break;
            case 3:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number3;
                break;
            case 4:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number4;
                break;
            case 5:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number5;
                break;
            case 6:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number6;
                break;
            case 7:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number7;
                break;
            case 8:
                this.transform.GetComponent<Renderer>().material = UnitMaterial.number8;
                break;
            default:break;
        }
    }

    public void Reset()
    {
        isNear = false;
        nearNum = 0;
        height = 0;
        length = 0;
        isMine = false;

        this.transform.GetComponent<Renderer>().material = UnitMaterial.blank;

    }
}
