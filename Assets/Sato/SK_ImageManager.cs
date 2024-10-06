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
    [SerializeField] GameObject _button1;
    [SerializeField] GameObject _button2;
    [SerializeField] GameObject _button3;
    [SerializeField] Text _btx1;
    [SerializeField] Text _btx2;
    [SerializeField] Text _btx3;
    [SerializeField] GameObject _eventObject;
    [SerializeField] GameObject _imagePrefab;
    public SK_ChoiceScript choiceScript;
    int l = 0;

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
        _textToButton = new Dictionary<string, GameObject>();
        _textToButton.Add("button1",_button1);
        _textToButton.Add("button2",_button2);
        _textToButton.Add("button3",_button3);
        _textToText = new Dictionary<string, Text>();
        _textToText.Add("button1",_btx1);
         _textToText.Add("button2",_btx2);
         _textToText.Add("button3",_btx3);

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
    
    public void ShowChoice(string buttonname, string line, string word)
    {
        l=int.Parse(line);
        _textToButton[buttonname].SetActive(true);
        choiceScript.changeline=l;
        _textToText[buttonname].text = word;
    }
}
