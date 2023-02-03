using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ui_button : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    public void Next()
    {
        if (this.tag == "Card")
            StartCoroutine(LoadLevel(7));
        if (this.tag == "Cube")
            StartCoroutine(LoadLevel(0));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelIndex);
    }
}
