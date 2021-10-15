using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    public static Status Instance;
    
    public Mode selected;
    public string userName;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.DontDestroyOnLoad(this);
        selected = new EasyMode();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Instance = this;
    }
}
