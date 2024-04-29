using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MemoryScript : MonoBehaviour
{
    [SerializeField] PauseScreen pauseScreen;

    public Transform container;
    public GameObject memFab;

    public PopUp PopUp;
    public float timer = 10;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        MemText pickedUpMemory = other.GetComponent<MemText>();

        if (other.gameObject.CompareTag("mem"))
        {
            Destroy(other.gameObject);
            pauseScreen.incrementMem();
            PopUp.playPopup();

            GameObject newUIThing = Instantiate(memFab, container);
            newUIThing.GetComponent<memoryInfo>().SetMessage(pickedUpMemory.memoryText);
        }
    }
}