using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SK_ChoiceScript : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public int changeline1;
    public int changeline2;
    public int changeline3;
    public int changeline4;
    public SK_GameManager GameManager;

    public void OnClick1()
    {
        GameManager.lineNumber=changeline1;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }

    public void OnClick2()
    {
        GameManager.lineNumber=changeline2;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }

    public void OnClick3()
    {
        GameManager.lineNumber=changeline3;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }

    public void OnClick4()
    {
        GameManager.lineNumber=changeline4;
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }

    void Start()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
        button4.SetActive(false);
    }

    void Update()
    {
        
    }
}
