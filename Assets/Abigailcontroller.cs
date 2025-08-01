using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abigailcontroller : MonoBehaviour
{
    Animator animator;
    public GameObject Effect;
    public GameObject Effect1;
    public GameObject Effect2;
    private bool ting;

    //bool lightOn = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        ting = Effect;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //lightOn = true;
            animator.SetBool("light", true);
            Effect.SetActive(true);  // Make sure this is assigned and enabled in the Inspector
        }

        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Space))
        {
            //lightOn = false;
            animator.SetBool("light", false);
            Effect.SetActive(false); // Optional: turn it off
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("light", true);
            //Effect.Play();
        }
        else
        {
            animator.SetBool("light", false);
            Effect.SetActive(false);
        }
        
        if (ting)
        {
            Debug.Log("hiiiiii");
        }
    }
}
