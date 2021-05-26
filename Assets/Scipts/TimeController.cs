using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Slider Time_Slider;
    public int TimeLimit;
    public static TimeController instance;
    // Start is called before the first frame update
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        Time_Slider.maxValue = TimeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        Time_Slider.value = TimeLimit;
    }
}
