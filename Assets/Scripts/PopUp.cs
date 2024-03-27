using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    private GameObject window;
    private Animator ani;


    private void Start()
    {
        window = transform.GetChild(0).gameObject;
        ani = window.GetComponent<Animator>();
        window.SetActive(false);
    }

    public void playPopup()
    {
        window.SetActive(true);
        ani.Play("MemPopUps");
        
    }

    public void endPopup()
    {
        window.SetActive(false);
    }
}