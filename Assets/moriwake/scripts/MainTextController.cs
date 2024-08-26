using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace NovelGame
{
    public class MainTextController : MonoBehaviour
    {
        [SerializeField] TextMeshProUGUI _mainTextObject;

        // Start is called before the first frame update
        void Start()
        {
            DisplayText();
        }

        // Update is called once per frame
        void Update()
        {
            // �N���b�N���ꂽ�Ƃ��A���̍s�ֈړ�
            if (Input.GetMouseButtonUp(0))
            {
                GoToTheNextLine();
                DisplayText();
            }
        }

        // ���̍s�ֈړ�
        public void GoToTheNextLine()
        {
            GameManager.Instance.lineNumber++;
        }

        // �e�L�X�g��\��
        public void DisplayText()
        {
            string sentence = GameManager.Instance.userScriptManager.GetCurrentSentence();
            _mainTextObject.text = sentence;
        }
    }
}