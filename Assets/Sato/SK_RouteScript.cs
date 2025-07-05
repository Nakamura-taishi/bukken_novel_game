using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SK_RouteScript : MonoBehaviour
{
    int n = 0;
    public Text text;
    public GameObject Image1;
    public GameObject Image2;
    public GameObject Image3;
    public GameObject Image4;
    public GameObject Image5;
    public GameObject Image6;
    public GameObject Image7;
    void Start()
    {
        n = SK_ImageManager.routenumber;
        Debug.Log(n);
        //text.text="{0}";
        Image1.SetActive(false);
        Image2.SetActive(false);
        Image3.SetActive(false);
        Image4.SetActive(false);
        Image5.SetActive(false);
        Image6.SetActive(false);
        Image7.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(n==1)
        {
            Image1.SetActive(true);
        }
        if(n==2)
        {
            Image2.SetActive(true);
        }
        if(n==3)
        {
            Image3.SetActive(true);
        }
        if(n==4)
        {
            Image4.SetActive(true);
        }
        if(n==5)
        {
            Image5.SetActive(true);
        }
        if(n==6)
        {
            Image6.SetActive(true);
        }
        if(n==7)
        {
            Image7.SetActive(true);
        }
    }
}
