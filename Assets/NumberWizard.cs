using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame(){
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizards.");
        Debug.Log("Please pick a number");
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Up Arrow for greater, Down Arrow for less, or Enter for correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            min = guess;
            NewGuess();
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            max = guess;
            NewGuess();
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Your number was " + guess + "!");
            StartGame();
        }
    }

    void NewGuess(){
        guess = (max + min) / 2;
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Up Arrow for greater, Down Arrow for less, or Enter for correct");
    }
}
