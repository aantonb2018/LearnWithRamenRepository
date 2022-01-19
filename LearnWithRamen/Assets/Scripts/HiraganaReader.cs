using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiraganaReader : MonoBehaviour
{
    private string path = "Hiragana";
    private TextAsset hiragana = new TextAsset();
    // Start is called before the first frame update
    void Awake()
    {
        hiragana = Resources.Load(path + "/hiragana") as TextAsset;

        string[] arrayString = hiragana.text.Split('\n');

        string[] auxAux;

        ListOfCharacters exampleList = ScriptableObject.CreateInstance<ListOfCharacters>();
        

        foreach (string character in arrayString)
        {
            auxAux = character.Split('|');
            string idx = auxAux[0];
            string romaji = auxAux[1];
            string hira = auxAux[2];
            string assetPath = "Assets/ScriptableObjects/HiraganaCharacters/hiragana_" + romaji + ".asset";

            Character example = ScriptableObject.CreateInstance<Character>();
            example.SetIdx(System.Int32.Parse(idx));
            example.SetRomaji(romaji);
            example.SetHiragana(hira);
            exampleList.Add(example);
            UnityEditor.AssetDatabase.CreateAsset(example, assetPath);
            UnityEditor.AssetDatabase.SaveAssets();
            UnityEditor.AssetDatabase.Refresh();
            UnityEditor.EditorUtility.FocusProjectWindow();
            UnityEditor.Selection.activeObject = example;

        }
        UnityEditor.AssetDatabase.CreateAsset(exampleList, "Assets/ScriptableObjects/hiraganaList.asset");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
