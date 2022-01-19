using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameCode : MonoBehaviour
{
    public ListOfCharacters dictionary;
    public TextMeshProUGUI question;
    public Button answerA;
    public Button answerB;
    public Button answerC;
    public Button answerD;
    /*
    public TextMeshProUGUI answerA;
    public TextMeshProUGUI answerB;
    public TextMeshProUGUI answerC;
    public TextMeshProUGUI answerD;*/
    Character solution;
    int solutionInt;
    // Start is called before the first frame update
    void Start()
    {
        ListOfCharacters dictionaryHelp = Instantiate(dictionary);
        int idx = (int)Random.Range(0f, 106f);
        solution = dictionaryHelp.GetAndRemoveById(idx);
        string questionString = solution.GetHiragana();
        string solutionString = solution.GetRomaji();
        question.text = questionString;

        Character[] otherChars = new Character[4];
        for(int i = 0; i < 4; i++)
        {
            otherChars[i] = dictionaryHelp.GetAndRemoveById((int)Random.Range(0f, 105f - i));
        }

        answerA.GetComponentInChildren<TextMeshProUGUI>().text = otherChars[0].GetRomaji();
        answerB.GetComponentInChildren<TextMeshProUGUI>().text = otherChars[1].GetRomaji();
        answerC.GetComponentInChildren<TextMeshProUGUI>().text = otherChars[2].GetRomaji();
        answerD.GetComponentInChildren<TextMeshProUGUI>().text = otherChars[3].GetRomaji();

        solutionInt = (int)Random.Range(0f, 3f);
        switch (solutionInt)
        {
            case 0:
                answerA.GetComponentInChildren<TextMeshProUGUI>().text = solutionString;
                break;
            case 1:
                answerB.GetComponentInChildren<TextMeshProUGUI>().text = solutionString;
                break;
            case 2:
                answerC.GetComponentInChildren<TextMeshProUGUI>().text = solutionString;
                break;
            case 3:
                answerD.GetComponentInChildren<TextMeshProUGUI>().text = solutionString;
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnterAnswer(int answer)
    {
        switch (answer)
        {
            case 0:
                if (answer == solutionInt) { CorrectAnswer(answerA); } else { WrongAnswer(answerA); }
                break;
            case 1:
                if (answer == solutionInt) { CorrectAnswer(answerB); } else { WrongAnswer(answerB); }
                break;
            case 2:
                if (answer == solutionInt) { CorrectAnswer(answerC); } else { WrongAnswer(answerC); }
                break;
            case 3:
                if (answer == solutionInt) { CorrectAnswer(answerD); } else { WrongAnswer(answerD); }
                break;
        }
    }

    private void CorrectAnswer(Button button)
    {
        button.GetComponent<Image>().color = new Color(0.2f, 1.0f, 0.2f);
        Debug.Log("EXITO");
        button.enabled = false;
    }

    private void WrongAnswer(Button button)
    {
        button.GetComponent<Image>().color = new Color(1.0f, 0.2f, 0.2f);
        Debug.Log("FALLO");
        button.enabled = false;
    }
}
