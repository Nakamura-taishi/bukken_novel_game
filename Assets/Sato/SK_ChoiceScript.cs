using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SK_ChoiceScript : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public int changeline;
    public SK_GameManager gameManager;

    public void OnClick1()
    {
        gameManager.lineNumber=changeline;
        button1.SetActive(false);
    }

    public void OnClick2()
    {
        gameManager.lineNumber=changeline;
        button2.SetActive(false);
    }

    public void OnClick3()
    {
        gameManager.lineNumber=changeline;
        button3.SetActive(false);
    }

    void Start()
    {
        button1.SetActive(false);
        button2.SetActive(false);
        button3.SetActive(false);
    }

    void Update()
    {
        
    }
}
