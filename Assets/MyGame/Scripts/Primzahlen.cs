using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Primzahlen : MonoBehaviour
{
    public TMP_InputField numberInputField;
    public TextMeshProUGUI resultText;

    private void Start()
    {
        // Add a listener to the "On End Edit" event of the input field.
        numberInputField.onEndEdit.AddListener(CheckNumber);
    }

    public void CheckNumber(string inputText)
    {
        if (string.IsNullOrEmpty(inputText))
        {
            resultText.text = "Bitte füge eine Nummer ein";
            return;
        }

        if (int.TryParse(inputText, out int number))
        {
            if (IsPrime(number))
            {
                resultText.text = "Yippe eine Primzahl";
            }
            else
            {
                resultText.text = "Nope, keine Primzahl";
            }
        }
        else
        {
            resultText.text = "Bitte gib eine Nummer ein";
        }
        //Hier wird der Text bestimmt welcher darauf basiert was "IsPrime" ergibt basirend auf die nummer (oder nicht nummer lol) die man eingibt ist//
    }

    bool IsPrime(int num)
    {
        if (num <= 1)
            return false;
        if (num <= 3)
            return true;
        if (num % 2 == 0 || num % 3 == 0)
            return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
                return false;
        }
        //Dieser komplizierte Salat aus nummern prüft ob etwas eine primzahl ist. kann ich es genau erklären? nö. Dafür existieren youtube tutorials >:3. Falls ich das vor der klasse zeigen muss werde ich weinen und die schule abbrechen und einfach falknerei machen. es ist 23 Uhr ich will das alles nicht mehr wie soll ich überhaupt die beispiele machen AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA Unity ist bald nicht mal mehr ein industriestandart bei irgendeiner größeren Firma T^T //
        return true;
    }
}

