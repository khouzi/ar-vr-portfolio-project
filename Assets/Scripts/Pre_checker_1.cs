using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pre_checker_1 : MonoBehaviour
{
    GameObject cube;
    bool moved = false;
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(("a1")))
        {
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0.7f, 0.2f, -6.5f);
            cube.transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<MeshRenderer>().enabled = false;
            cube.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (cube)
        {
            cube.transform.position = new Vector3(0, 0, 0);
            moved = true;
        }
    }


    private void FixedUpdate()
    {
        if (moved == true && cube)
        {
            Destroy(cube);
            moved = false;
        }
    }
}
