using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public OpenDoor Left_Door;
    public OpenDoor Right_Door;
    public OpenDoor Chest;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            Left_Door.ToggleDoor();
            Right_Door.ToggleDoor();
            Chest.ToggleDoor();
            
        }
    }

}
