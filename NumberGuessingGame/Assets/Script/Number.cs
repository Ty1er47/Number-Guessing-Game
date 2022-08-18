using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess = 5;
    private int minValue = 1;
    private int maxValue = 10;
    
    // Start is called before the first frame update
    void Start()
    {
     Debug.Log("Welcome to our Number Guessing Game.");
     Debug.Log("The number range is from " + minValue + " and " + maxValue);
     Debug.Log("Guess a number between the given range");
     Debug.Log("Tell me if your number is higher or lower than: " + guess + "?");
     Debug.Log("push up arrow = Higher, Push down arrow ;lower, Push Enter = Correct");
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.UpArrow))
       {
         minValue = guess;
         guess = (maxValue + minValue) / 2;
         Debug.Log("Is it higher or lower than: " + guess);
       } 
       if(Input.GetKeyDown(KeyCode.DownArrow))
       {
           maxValue = guess;
           guess = (maxValue + minValue) /2;
           Debug.Log("Is it higher or lower than: " + guess);
        }
    }
}
