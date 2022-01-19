using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HiraganaCharacter", menuName = "ScriptableObjects/HiraganaCharacters/Character", order = 1)]
public class Character : ScriptableObject
{
    [SerializeField] private int idx;
    [SerializeField] private string romaji;
    [SerializeField] private string hiragana;

    public int GetIdx()
    {
        return idx;
    }

    public void SetIdx(int idx)
    {
        this.idx = idx;
    }

    public string GetRomaji()
    {
        return romaji;
    }

    public void SetRomaji(string romaji)
    {
        this.romaji = romaji;
    }

    public string GetHiragana()
    {
        return hiragana;
    }

    public void SetHiragana(string hiragana)
    {
        this.hiragana = hiragana;
    }
}
