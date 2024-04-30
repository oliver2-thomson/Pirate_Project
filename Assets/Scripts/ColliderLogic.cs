using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLogic : MonoBehaviour
{
    public OpenDoor AnimatedObject;
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
        if (other.tag == "Player")
        {
            AnimatedObject.activate();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AnimatedObject.deactivate();
        }
    }
}
