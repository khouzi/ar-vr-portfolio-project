using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tablet : MonoBehaviour
{
    public GameObject GreenButton, GreenButtonHol, RedButton, RedButtonHol;
    public Animator animator1, animator2, transition;
    public float transitionTime = 1f;
    int scene;


    private void Awake()
    {
        scene = SceneManager.GetActiveScene().buildIndex;
    }

    public void ActivationGreen()
    {
        GreenButton.SetActive(true);
        GreenButtonHol.SetActive(false);
    }

    public void GoWhiteBoard()
    {
        SceneManager.LoadScene(6);
    }

    public void ExitGreen()
    {
        animator1.SetTrigger("Tablet_Trigger");
        StartCoroutine(LoadAnimationG());
    }

    IEnumerator LoadAnimationG()
    {
        yield return new WaitForSeconds(transitionTime);
        GreenButton.SetActive(false);
        GreenButtonHol.SetActive(true);
    }


    public void ActivationRed()
    {
        RedButton.SetActive(true);
        RedButtonHol.SetActive(false);
    }

    public void ExitRed()
    {
        animator2.SetTrigger("Red Exit");
        StartCoroutine(LoadAnimationR());
    }

    IEnumerator LoadAnimationR()
    {
        yield return new WaitForSeconds(transitionTime);
        RedButton.SetActive(false);
        RedButtonHol.SetActive(true);
    }

    public void ExitScene()
    {
        StartCoroutine(LoadLevel(4));
    }

    public void ReloadScene()
    {
        StartCoroutine(LoadLevel(scene));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime + 0.5f);

        SceneManager.LoadScene(levelIndex);
    }
    

    
}
