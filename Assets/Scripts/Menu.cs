using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public string LevelChange;
   
    public void LoadLevel()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       //Credit to Kap Koder with button https://www.youtube.com/watch?v=mGjqmK_O5jA
    }
    

    
}
