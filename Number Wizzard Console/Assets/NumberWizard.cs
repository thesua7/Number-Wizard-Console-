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

       Debug.Log("Welcome to the GAME!!"+"\n"); 
       Debug.Log("Pick a number: "+"\n");
       Debug.Log("Highest number is: "+max+"\n");
       Debug.Log("Lowest number is: "+min+"\n");
       Debug.Log("Tell me your number is higer or lower than 500 "+"\n");
       Debug.Log("Press UP=Higher,Press Down=Lower & Press Enter=Correct"+"\n");

    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up Arrow key was pressed");
        }

          if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow key was pressed");
        }

          if (Input.GetKeyDown(KeyCode.Return))
        {
            print("Enter key was pressed");
        }
    }


}
