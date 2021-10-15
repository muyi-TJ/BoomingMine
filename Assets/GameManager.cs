using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //实例
    public static GameManager Instance;

    //相关配置
    public Mode presentMode;

    //相关物体
    public Map Map;
    public Generator Generator;

    // Start is called before the first frame update
    void Start()
    {
        Map.Initial();
        Generator.StartGenerate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Instance = this;
        presentMode = Status.Instance.selected;
    }

    public void SetGamePause(bool pause)
    {
        Time.timeScale = pause ? 0 : 1;
    }
}
