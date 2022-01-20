using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "RamenDish", menuName = "ScriptableObjects/HiraganaCharacters/RamenDish", order = 4)]
public class RamenDishes : ScriptableObject
{
    [SerializeField] string dishName;
    [SerializeField] List<Character> listOfCharacter = new List<Character>();
    [SerializeField] string dishDescription;
    [SerializeField] Sprite dishSprite;

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

    public string GetDishName()
    {
        return dishName;
    }

    public string GetDishDesc()
    {
        return dishDescription;
    }

    public Sprite GetDishSprite()
    {
        return dishSprite;
    }
}
