using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update

    int max;
    int min;
    int guess;
    void Start()
    {

     StartGame();

    }

    void StartGame(){

       max = 1001;
       min = 1;
       guess = 500;

       Debug.Log("Hola! Mai peoplez!!! Welcome to the GAME!!"+"\n"); 
       Debug.Log("Pick a number mai peoplez!!!!!!!!!"+"\n");
       Debug.Log("Highest number you can pick is: "+(max-1)+"\n");
       Debug.Log("Lowest number you can pick is: "+min+"\n");
       Debug.Log("Tell me your number is higher or lower than "+guess+"\n");
       Debug.Log("Press UP=Higher,Press Down=Lower & Press Enter=Correct"+"\n");
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
            min = guess;
            NextGuess();
            
        }

          else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
   
            max = guess;
            NextGuess(); 
         
        }

          else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("B00M Dia!");
            StartGame();
        }
    }

    void NextGuess(){
       guess = (max+min)/2;
        Debug.Log(guess);
    }


}
