 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameroncontroller : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    public GameObject Effect;
    public GameObject Effect2;
    private bool fast;
    private bool music;
    private bool isidle;
    private bool quickjump;
    private bool walk;
    private bool sword;
    private bool attack;
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
        //Start the coroutine we define below named ExampleCoroutine.
        fast = animator.GetBool("fast");
        music = animator.GetBool("music");
        isidle = animator.GetBool("isidle");
        quickjump = animator.GetBool("quickjump");
        walk = animator.GetBool("walk");
        sword = animator.GetBool("sword");
        attack = animator.GetBool("attack");
    }

    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        animator.SetBool("isidle", true);
        yield return new WaitForSeconds(1f);
        Debug.Log("Waited for 3 seconds.");
        //yield on a new YieldInstruction that waits for 5 seconds.
        animator.SetBool("isidle", false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
    IEnumerator runjump()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        animator.SetBool("quickjump", true);
        yield return new WaitForSeconds(0.6f);
        Debug.Log("Waited for 3 seconds.");
        //yield on a new YieldInstruction that waits for 5 seconds.
        animator.SetBool("quickjump", false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }
        IEnumerator swordy()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        animator.SetBool("attack", true);
        yield return new WaitForSeconds(0.6f);
        Debug.Log("Waited for 3 seconds.");
        //yield on a new YieldInstruction that waits for 5 seconds.
        animator.SetBool("attack", false);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }



    // Update is called once per frame
    void Update()
    {

        //bool isidle = animator.GetBool("isidle");


        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(ExampleCoroutine());
        }
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("walk", true);
            Effect2.SetActive(true);
        }
        else
        {
            animator.SetBool("walk", false);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            animator.SetBool("sword", true);
            Debug.Log("" + Time.time);
        }
        if (Input.GetKey(KeyCode.Alpha1))
        {
            if (sword)
            {
                animator.SetBool("sword", false);
            }
        }
        if (Input.GetKey(KeyCode.F))
        {
            StartCoroutine(swordy());
        }
        //else
            //{
            //    animator.SetBool("isidle", false);
            //}
            // Check if the Space key is currently held down
            if (Input.GetKey(KeyCode.LeftShift))
            {
                animator.SetBool("fast", true);
            }
            else
            {
                animator.SetBool("fast", false);
            }
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(runjump());
        }



    }
}
