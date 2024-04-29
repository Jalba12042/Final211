using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class memoryInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject player = null;

    int index;

    private string msg;

    public void Start()
    {
        player = GameObject.Find("Player");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        FindObjectOfType<memoryText>().SetText(msg);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        FindObjectOfType<memoryText>().SetText("Mouse over a memory item to see information here.");
    }

    public void SetMessage(string m) { msg = m; }
}
