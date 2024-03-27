using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BackToMenu : MonoBehaviour
{
    public string LevelChange;
   
    public void LoadM()
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
       //Credit to Kap Koder with button https://www.youtube.com/watch?v=mGjqmK_O5jA
    }
    

    
}
