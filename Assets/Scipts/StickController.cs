
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.UI;
using UnityEngine.UI;
using LTAUnityBase.Base.DesignPattern;

public class StickController : MonoBehaviour
{
    [SerializeField]
    Vector2 size = new Vector2(200, 200);
    [SerializeField]
    GameObject templeball;
    private Sprite mImageEven;
    void Start()
    {
        LoadSeeBall(null);
    }
    void LoadSeeBall(object data)
    {
        Transform transParent = templeball.transform.parent;
        while (transParent.childCount > 4)
        {
            Transform transChild = transParent.GetChild(transParent.childCount - 4);
            transChild.SetParent(null, false);
            Destroy(transChild.gameObject);
        }

        for (int i = 0; i < 1000; i++)
        {
            SetBtnBet(i, transParent);
        }

    }


    void SetBtnBet(int i, Transform transParent)
    {
        GameObject img = Instantiate(templeball) as GameObject;
        int a = Random.Range(1,4);
        for (int j = 0; j < a; j++)
        {
            img.transform.GetChild(j).gameObject.SetActive(true);
        }
        img.transform.GetChild(3).GetComponent<Text>().text = (i+1).ToString();
        img.SetActive(true);
        img.transform.SetParent(transParent, false);
    }
    private void OnDestroy()
    {
    }
}