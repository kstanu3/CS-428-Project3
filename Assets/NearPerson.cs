using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearPerson : MonoBehaviour
{
    Animator animator;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
    }

    public void IsNear()
    {
        animator.SetBool("IsNear", true);
        audio.Play();
        StartCoroutine(wait());

    }
    public void NotNear()
    {
        animator.SetBool("IsNear", false);
    }


}
