using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DishList", menuName = "ScriptableObjects/HiraganaCharacters/DishList", order = 5)]
public class DishList : ScriptableObject
{
    [SerializeField] List<RamenDishes> listOfDishes = new List<RamenDishes>();

    public void Add(RamenDishes dish)
    {
        listOfDishes.Add(dish);
    }

    public RamenDishes GetById(int idx)
    {
        return listOfDishes[idx];
    }

    public RamenDishes GetRandom(int idx)
    {
        int random = (int)Random.Range(0f, listOfDishes.Count);
        return listOfDishes[random];
    }

    public RamenDishes GetAndRemoveById(int idx)
    {
        RamenDishes returnable = listOfDishes[idx];
        listOfDishes.RemoveAt(idx);
        return returnable;
    }
}
