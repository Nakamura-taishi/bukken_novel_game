using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SK_UserScriptManager : MonoBehaviour
{
    [SerializeField] TextAsset _textFile;
    public int branch = 0;

        // 文章中の文（ここでは１行ごと）を入れておくためのリスト
        List<string> _sentences = new List<string>();

        void Awake()
        {
            // テキストファイルの中身を、１行ずつリストに入れておく
            StringReader reader = new StringReader(_textFile.text);
            while (reader.Peek() != -1)
            {
                string line = reader.ReadLine();
                _sentences.Add(line);
            }
        }

        // 現在の行の文を取得する
        public string GetCurrentSentence()
        {
            return _sentences[SK_GameManager.Instance.lineNumber];
        }

         // 文が命令かどうか
        public bool IsStatement(string sentence)
        {
            if (sentence[0] == '&')
            {
                return true;
            }
            return false;
        }

        // 命令を実行する
        public void ExecuteStatement(string sentence)
        {
            string[] words = sentence.Split(' ');
            switch(words[0])
            {
                case "&img":
                    SK_GameManager.Instance.imageManager.PutImage(words[1], words[2]);
                    break;
                case "&rmimg":
                    SK_GameManager.Instance.imageManager.RemoveImage(words[1]);
                    break;
                case "&choice1":
                    SK_GameManager.Instance.imageManager.ShowChoice1(words[1], words[2], words[3]);
                    break;
                case "&choice2":
                    SK_GameManager.Instance.imageManager.ShowChoice2(words[1], words[2], words[3]);
                    break;
                case "&choice3":
                    SK_GameManager.Instance.imageManager.ShowChoice3(words[1], words[2], words[3]);
                    break;
                case "&choice4":
                    SK_GameManager.Instance.imageManager.ShowChoice4(words[1], words[2], words[3]);
                    break;
                case "&change":
                    SK_GameManager.Instance.imageManager.ChangeLine(words[1]);
                    break;
            }
        }
}
