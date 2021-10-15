using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //ʵ��
    public static GameManager Instance;

    //�������
    public Mode presentMode;

    //�������
    public Map Map;

    // Start is called before the first frame update
    void Start()
    {
        
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
