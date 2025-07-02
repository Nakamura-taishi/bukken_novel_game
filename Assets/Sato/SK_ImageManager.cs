using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SK_ImageManager : MonoBehaviour
{
    public GameObject button;
    [SerializeField] Sprite _background1;
    [SerializeField] GameObject _backgroundObject;
    [SerializeField] Sprite _eventCG1;
    [SerializeField] Sprite _eventCG2;
    [SerializeField] Sprite _eventCG3;
    [SerializeField] Sprite _eventCG4;
    [SerializeField] Sprite _eventCG5;
    [SerializeField] Sprite _eventCG6;
    [SerializeField] Sprite _eventCG7;
    [SerializeField] GameObject _button1;
    [SerializeField] GameObject _button2;
    [SerializeField] GameObject _button3;
    [SerializeField] GameObject _button4;
    [SerializeField] Text _btx1;
    [SerializeField] Text _btx2;
    [SerializeField] Text _btx3;
    [SerializeField] Text _btx4;
    [SerializeField] GameObject _eventObject;
    [SerializeField] GameObject _imagePrefab;
    public SK_ChoiceScript choiceScript;
    /*public SK_ChoiceScript choiceScript2;
    public SK_ChoiceScript choiceScript3;
    public SK_ChoiceScript choiceScript4;*/
    public SK_GameManager GameManager;
    int l1 = 0;
    int l2 = 0;
    int l3 = 0;
    int l4 = 0;
    int n = 0;

    // テキストファイルから、文字列でSpriteやGameObjectを扱えるようにするための辞書
    Dictionary<string, Sprite> _textToSprite;
    Dictionary<string, GameObject> _textToParentObject;
    Dictionary<string, GameObject> _textToButton;
    Dictionary<string, Text> _textToText;

    // 操作したいPrefabを指定できるようにするための辞書
    Dictionary<string, GameObject> _textToSpriteObject;

    void Awake()
    {
        _textToSprite = new Dictionary<string, Sprite>();
        _textToSprite.Add("background1", _background1);
        _textToSprite.Add("eventCG1", _eventCG1);
        _textToSprite.Add("eventCG2", _eventCG2);
        _textToSprite.Add("eventCG3", _eventCG3);
        _textToSprite.Add("eventCG4", _eventCG4);
        _textToSprite.Add("eventCG5", _eventCG5);
        _textToSprite.Add("eventCG6", _eventCG6);
        _textToSprite.Add("eventCG7", _eventCG7);
        _textToButton = new Dictionary<string, GameObject>();
        _textToButton.Add("button1",_button1);
        _textToButton.Add("button2",_button2);
        _textToButton.Add("button3",_button3);
        _textToButton.Add("button4",_button4);
        _textToText = new Dictionary<string, Text>();
        _textToText.Add("button1",_btx1);
        _textToText.Add("button2",_btx2);
        _textToText.Add("button3",_btx3);
        _textToText.Add("button4",_btx4);

        _textToParentObject = new Dictionary<string, GameObject>();
        _textToParentObject.Add("backgroundObject", _backgroundObject);
        _textToParentObject.Add("eventObject", _eventObject);

        _textToSpriteObject = new Dictionary<string, GameObject>();
    }

    // 画像を配置する
    public void PutImage(string imageName, string parentObjectName)
    {
        Sprite image = _textToSprite[imageName];
        GameObject parentObject = _textToParentObject[parentObjectName];
        Vector2 position = new Vector2(0, 0);
        Quaternion rotation = Quaternion.identity;
        Transform parent = parentObject.transform;
        GameObject item = Instantiate(_imagePrefab, position, rotation, parent);
        item.GetComponent<Image>().sprite = image;
        _textToSpriteObject.Add(imageName, item);
    }

    public void RemoveImage(string imageName)
    {
        Destroy(_textToSpriteObject[imageName]);
    }
    
    public void ShowChoice1(string buttonname1, string line1, string word1)
    {
        l1=int.Parse(line1);
        _textToButton[buttonname1].SetActive(true);
        choiceScript.changeline1=l1;
        _textToText[buttonname1].text = word1;
    }

    public void ShowChoice2(string buttonname2, string line2, string word2)
    {
        l2=int.Parse(line2);
        _textToButton[buttonname2].SetActive(true);
        choiceScript.changeline2=l2;
        _textToText[buttonname2].text = word2;
    }

    public void ShowChoice3(string buttonname3, string line3, string word3)
    {
        l1=int.Parse(line3);
        _textToButton[buttonname3].SetActive(true);
        choiceScript.changeline3=l3;
        _textToText[buttonname3].text = word3;
    }

    public void ShowChoice4(string buttonname4, string line4, string word4)
    {
        l4=int.Parse(line4);
        _textToButton[buttonname4].SetActive(true);
        choiceScript.changeline4=l4;
        _textToText[buttonname4].text = word4;
    }

    public void ChangeLine(string Line)
    {
        Debug.Log("a");
        n=int.Parse(Line);
        GameManager.lineNumber=n;
    }
}
