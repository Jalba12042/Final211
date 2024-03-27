using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PauseScreen : MonoBehaviour
{
    public Canvas CanvasObject;
    //how many memories the player currently has
    public int memAmount = 0;
    public TMP_Text text;

    void Start()
    {
        CanvasObject.GetComponent<Canvas>().enabled = false;
    }

    void Update()
    {    
        text.text = "Memories Collected: " + memAmount;

        //if press escape and canvas is false
        if (Input.GetKeyDown(KeyCode.Escape) && (CanvasObject.GetComponent<Canvas>().enabled == false))
        {
            //enable canvas
            Cursor.lockState = CursorLockMode.None;
            CanvasObject.GetComponent<Canvas>().enabled = true;
            Time.timeScale = 0;
        }
        //if press escape and canvas is true
        else if (Input.GetKeyDown(KeyCode.Escape) && (CanvasObject.GetComponent<Canvas>().enabled == true))
        {
            //disable canvas
            Cursor.lockState = CursorLockMode.Locked;
            CanvasObject.GetComponent<Canvas>().enabled = false;
            Time.timeScale = 1;
        }
    }

    public void setMem(int amt)
    {
        memAmount = amt;
    }

    public int getMem()
    {
        return memAmount;
    }

    public void incrementMem()
    {
        memAmount++;
    }
}
