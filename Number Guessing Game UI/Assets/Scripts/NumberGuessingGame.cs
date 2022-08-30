using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberGuessingGame : MonoBehaviour
{
    [SerializeField] private int guess;
    [SerializeField] private int minValue;
    [SerializeField] private int maxValue;
    [SerializeField] private TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {
       StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I see that I've guessed your number, I suppose that I have won.");
            Debug.Log("");
            StartGame();
        }
    }

    public void OnPressHigher()
    {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
    }

    public void OnPressLower()
    {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
    }

    public void NextGuess()
    {
            guess = Random.Range(minValue, maxValue + 1);
            guessText.text = guess.ToString();
    }

    void StartGame()
    {
        guess= 5;
        minValue = 1;
        maxValue = 10;
        maxValue = maxValue + 1;
        
        NextGuess();
    }
}
