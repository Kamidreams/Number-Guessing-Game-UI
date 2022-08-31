using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuessingGame : MonoBehaviour
{
    [SerializeField] private int guess;
    [SerializeField] private int minValue = 1;
    [SerializeField] private int maxValue = 100;
    [SerializeField] private TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }

    public void OnPressHigher()
    {
            minValue = guess + 1;
            NextGuess();
    }

    public void OnPressLower()
    {
            maxValue = guess - 1;
            NextGuess();
    }

    public void NextGuess()
    {
            guess = Random.Range(minValue, maxValue + 1);
            guessText.text = guess.ToString();
    }

    void StartGame()
    {
        NextGuess();
    }
}
