using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public OpenDoor Left_Door;
    public OpenDoor Right_Door;
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
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "Door Collider")
        {
            print("collided");
        }
    }

}
