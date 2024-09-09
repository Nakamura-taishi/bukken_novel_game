using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SK_ChoiceScript : MonoBehaviour
{
    public GameObject button1;
    public int changeline;
    public SK_GameManager gameManager;

    public void OnClick()
    {
        gameManager.lineNumber=11;
        button1.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        button1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
