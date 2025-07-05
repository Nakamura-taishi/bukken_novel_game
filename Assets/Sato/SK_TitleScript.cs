using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SK_TitleScript : MonoBehaviour
{
    [SerializeField] Text nextText;

    public void Onclick()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void Finish()
    {
        UnityEditor.EditorApplication.isPlaying=false;
        Application.Quit();
    }
    void Start()
    {
        //SceneManager.UnloadScene("MainScene");
    }
}
