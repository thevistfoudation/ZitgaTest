using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject PanelPlay;
    public GameObject Replay;
    public GameObject PanelHint;
    public GameObject Hint;
    public GameObject ButtonPlay;
    public GameObject Lose;
    private void Awake()
    {
        if (instance == null) instance = this;
    }
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        CheckTime();
        Hint.SetActive(true);
    }
    public void CheckTime()
    {
        if(TimeController.instance.TimeLimit == 0)
        {
            Time.timeScale = 0;
            Lose.SetActive(true);
        }
        else if(TimeController.instance.TimeLimit >= 0)
        {
            TimeController.instance.TimeLimit -= 1;
        }
    }
    public void OpenHint()
    {
        PanelHint.SetActive(true);
    }
    public void ShutdownHint()
    {
        PanelHint.SetActive(false);
    }
    public void GameOff()
    {
        ButtonPlay.SetActive(false);
        //LeanTween.delayedCall(10f, () =>
        //{
        //    PanelPlay.SetActive(true);
        //});
    }
    public void GameOn()
    {
        PanelPlay.SetActive(false);
        ButtonPlay.SetActive(true);
    }
    public void Home()
    {
        SceneManager.LoadScene(1);
    }
    
}
