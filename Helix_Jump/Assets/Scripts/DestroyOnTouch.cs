using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTouch : MonoBehaviour
{
    public GameObject StartingText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetMouseButton(0))
        {
            Destroy(StartingText.gameObject); 
            Debug.Log("Pressed left click.");
        }
    }

   
}
