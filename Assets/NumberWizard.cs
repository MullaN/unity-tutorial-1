using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int max = 1000;
        int min = 1;

        Debug.Log("Welcome to Number Wizards.");
        Debug.Log("Please pick a number");
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Debug.Log("Up Key was pressed.");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
            Debug.Log("Down Key was pressed.");
        }
        else if(Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("Return was pressed.");
        }
    }
}
