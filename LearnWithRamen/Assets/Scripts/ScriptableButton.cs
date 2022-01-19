using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "CharacterButton", menuName = "ScriptableObjects/HiraganaCharacters/CharacterButton", order = 4)]
public class ScriptableButton : ScriptableObject
{
    [SerializeField] public int answerIdx;
    [SerializeField] public Button answerButton;
}
