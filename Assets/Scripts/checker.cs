using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class checker : MonoBehaviour
{
    int count = 0;
    public GameObject Rabbits = null, Bush = null, canva = null, Button = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other)
        {
            count++;
        }
    }

    

    private void OnTriggerExit(Collider other)
    {
        if (other)
        {
            count--;
        }
    }

    private void Show()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(count);
        }
    }

    private void Win()
    {
        int sceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (count == 4)
        {
            if (sceneIndex == 0)
            {
                canva.SetActive(false);
                Bush.SetActive(true);
                Rabbits.SetActive(true);
                Button.SetActive(true);
            }
            else if (sceneIndex == 3)
            {
                canva.SetActive(false);
                Rabbits.SetActive(true);
                Button.SetActive(true);
            }
        }

        if (count == 3 && (sceneIndex == 1 || sceneIndex == 2))
        {
            canva.SetActive(false);
            Rabbits.SetActive(true);
            Button.SetActive(true);
        }
    }

    
private void Update()
    {
        Show();
        Win();
    }
}
