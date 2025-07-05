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
    void Start()
    {
        n = SK_ImageManager.routenumber;
        Debug.Log(n);
        text.text="{0}";
        Image1.SetActive(false);
        Image2.SetActive(false);
        Image3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(n==1)
        {
            text.text="1";
            Image1.SetActive(true);
        }
    }
}
