using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HiraganaList", menuName = "ScriptableObjects/HiraganaCharacters/ListOfCharacters", order = 3)]
public class ListOfCharacters : ScriptableObject
{

    [SerializeField] List<Character> listOfCharacter = new List<Character>();

    public void Add(Character character)
    {
        listOfCharacter.Add(character);
    }

    public Character GetById(int idx)
    {
        return listOfCharacter[idx];
    }

    public Character GetAndRemoveById(int idx)
    {
        Character returnable = listOfCharacter[idx];
        listOfCharacter.RemoveAt(idx);
        return returnable;
    }
}
