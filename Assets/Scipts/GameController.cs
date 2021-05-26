using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject Panel;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        CheckTime();
    }
    public void CheckTime()
    {
        if(TimeController.instance.TimeLimit == 0)
        {
            Time.timeScale = 0;
        }
        else if(TimeController.instance.TimeLimit >= 0)
        {
            TimeController.instance.TimeLimit -= 1;
        }
    }
    public void GameOn()
    {
        Panel.SetActive(false);
    }
    public void GamePlay()
    {
        SceneManager.LoadScene(2);
    }
}
