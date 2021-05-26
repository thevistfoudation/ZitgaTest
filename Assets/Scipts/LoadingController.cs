using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadingController : MonoBehaviour
{
    #region Var
    SpriteRenderer spriteRenderer;
    public Slider Loading_Slider;
    public int Loading;
    public GameObject Name;
    public GameObject NameAni;
    
    #endregion

    // Start is called before the first frame update
    #region Unity Method
    void Start()
    {
       
        Loading_Slider.maxValue = Loading;
        StartCoroutine(spawnItem());
    }

    // Update is called once per frame
    void Update()
    {
        Loading_Slider.value = Loading;
        if (Loading == 0)
        {
            Debug.Log("chuyen senmce");
            SceneManager.LoadScene(1);
            
        }
        else if(Loading == 3)
        {
            Name.SetActive(false);
            NameAni.SetActive(true);
        }
    }
    IEnumerator spawnItem()
    {
        while (true)
        {
            Loading -= 1;
            yield return new WaitForSeconds(1f);
        }
    }
    #endregion
}
