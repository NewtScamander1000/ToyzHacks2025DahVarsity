using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirandacontroller : MonoBehaviour
{
    Animator animator;
    public GameObject Effect1;
    public GameObject Effect2;
    private bool fast;
    private bool phone;
    private bool teleport;

    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        fast = animator.GetBool("fast");
        phone = animator.GetBool("phone");
        teleport = animator.GetBool("teleport");
    }



    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("fast", true);
        }
        else
        {
            animator.SetBool("fast", false);
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("phone", true);
        }
        else
        {
            animator.SetBool("phone", false);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            animator.SetBool("teleport", true);
        }
        else
        {
            animator.SetBool("teleport", false);
        }
    }
}