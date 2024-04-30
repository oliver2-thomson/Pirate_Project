using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    private Animator animator;
    bool colliding;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        colliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleDoor()
    {
        // Trigger the "Open" animation
        if (colliding)
        {
            animator.SetTrigger("Click");

        }
        
    }

    public void activate()
    {
        colliding = true;
    }

    public void deactivate()
    {
        colliding = false;
    }
}
