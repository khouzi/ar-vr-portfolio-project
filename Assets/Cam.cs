using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;



public class Cam : MonoBehaviour
{
    Vector3 Offset;

    public void Start()
    {
        Offset = new Vector3(10.94f, 1.5f, -7.869f);
        this.transform.position = Offset;
    }

}
