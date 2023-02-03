using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject canvas_1, canvas_2 ;
    public Animator animator_1, animator_2;
    public float transitionTime = 1f;


    private void Start()
    {
        canvas_1.SetActive(false);
        canvas_2.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            canvas_1.SetActive(true);
            canvas_2.SetActive(true);
            Debug.Log("entered");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("hi");
        animator_1.SetTrigger("bubble_exit");
        animator_2.SetTrigger("bubble_exit");
        Wait();
    }

    public void Wait()
    {
        StartCoroutine(LoadAnimation());
    }

    IEnumerator LoadAnimation()
    {
        yield return new WaitForSeconds(transitionTime);
        canvas_1.SetActive(false);
        canvas_2.SetActive(false);

    }
}
