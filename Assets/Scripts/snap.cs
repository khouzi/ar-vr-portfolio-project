using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snap : MonoBehaviour
{
	public float snapDistance = 1;
	public List<Transform> nodes = new List<Transform>();
	public float HologramShowDistance = 0.22f;
	public List<GameObject> holnodes = new List<GameObject>();
	public float num = 0.01f;
	public Vector3 offset = new Vector3(0f, 0f, 0f);

	void Update()
	{
		float smallestDistanceSquared = snapDistance * snapDistance;
		float smallestHolDistanceSquared = HologramShowDistance * HologramShowDistance;


		//set all holograms off
		foreach (GameObject node in holnodes)
		{
			node.SetActive(false);
		}


		//snap position code
		foreach (Transform node in nodes)
		{
			if ((node.position - transform.position).sqrMagnitude < smallestDistanceSquared)
			{
				transform.SetPositionAndRotation(node.position + offset, node.rotation);
				smallestDistanceSquared = (node.position - transform.position).sqrMagnitude;
			}
		}


		//show the hologram
		foreach (GameObject node in holnodes)
		{

			if ((node.transform.position - transform.position).sqrMagnitude < smallestHolDistanceSquared)
			{
				node.SetActive(true);
				smallestHolDistanceSquared = (node.transform.position - transform.position).sqrMagnitude;
			}

			if ((node.transform.position - transform.position).sqrMagnitude < num)
			{
				node.SetActive(false);
			}

		}

	}

}

