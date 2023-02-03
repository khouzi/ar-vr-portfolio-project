using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_Destroyer : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (transform.position.x <= -1.1)
        {
            Destroy(gameObject);
        }

    }
}
