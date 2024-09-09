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
    //[SerializeField] Button _button1;
    [SerializeField] GameObject _eventObject;
    [SerializeField] GameObject _imagePrefab;

    // テキストファイルから、文字列でSpriteやGameObjectを扱えるようにするための辞書
    Dictionary<string, Sprite> _textToSprite;
    Dictionary<string, GameObject> _textToParentObject;
    //Dictionary<string, Button> _textToButton;

    // 操作したいPrefabを指定できるようにするための辞書
    Dictionary<string, GameObject> _textToSpriteObject;

    void Awake()
    {
        _textToSprite = new Dictionary<string, Sprite>();
        _textToSprite.Add("background1", _background1);
        _textToSprite.Add("eventCG1", _eventCG1);
        _textToSprite.Add("eventCG2", _eventCG2);
        //_textToButton.Add("button1",_button1);

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
    
    public void ShowChoice(string buttonname)
    {
        //Button button_ = _textToButton[buttonname];
        button.SetActive(true);
    }
}
