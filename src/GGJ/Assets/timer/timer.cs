using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    
    public float start_time = 0;
    private float current_time = 0;
    private int current_time_int = 0;

    public Text timerTextBox;
    private string timerText;
    // Start is called before the first frame update
    void Start()
    {
        current_time = start_time; //initial the timer
        timerTextBox.text = ""; 
    }

    // Update is called once per frame
    void Update()
    {
        if (current_time > 0)
        {
            current_time -= 1 * Time.deltaTime;
            current_time_int = (int)current_time;//set current time to int

            timerText = current_time_int.ToString(); //int to string

            int textLength = timerText.Length; //set up the timer format to 00:00
            string tempString = "";
            if (textLength % 2 != 0)
            {
                timerText=timerText.Insert(0, "0");
                textLength += 1;
            }
            for (int i = 0; i<textLength; i++)
            {
                if (i!=0 && i % 2 == 0)
                {
                    tempString += ":";
                }
                tempString += timerText.Substring(i,1);
            }

            timerTextBox.text = tempString;
        }
    }
}
