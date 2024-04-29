using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public OpenDoor door;
    // Start is called before the first frame update
    void Start()
    {
        door = GetComponent<OpenDoor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            print("1");
            door.ToggleDoor();
            
        }
    }

    /* void openDoor()
    {
        
    }
    */
}
