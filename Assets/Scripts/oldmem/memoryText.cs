using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class memoryText : MonoBehaviour
{
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetText(string msg)
    {
        text.text = msg;
    }
}
