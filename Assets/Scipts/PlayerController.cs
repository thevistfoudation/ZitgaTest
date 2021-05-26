using LTAUnityBase.Base.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LTAUnityBase.Base.DesignPattern;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    ButtonController Right, Left, Up, Down;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Right.OnClick((ButtonController btn) =>
        {
            //this.gameObject.transform.position -= new Vector3(-1, 0, 0) * Time.deltaTime * Speed;
            this.gameObject.transform.eulerAngles = Vector3.forward * -90;
            Lines.instance.Right();
        });
        Left.OnClick((ButtonController btn) =>
        {
            //this.gameObject.transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * Speed;
            this.gameObject.transform.eulerAngles = Vector3.forward * 90;
            Lines.instance.Left();
        });
        Up.OnClick((ButtonController btn) =>
        {
            //this.gameObject.transform.position -= new Vector3(0, -1, 0) * Time.deltaTime * Speed;
            this.gameObject.transform.eulerAngles = Vector3.forward * 360;
            Lines.instance.Up();
        });
        Down.OnClick((ButtonController btn) =>
        {
            //this.gameObject.transform.position -= new Vector3(0, 1, 0) * Time.deltaTime * Speed;
            this.gameObject.transform.eulerAngles = Vector3.forward * -180;
            Lines.instance.Down();
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   


}
