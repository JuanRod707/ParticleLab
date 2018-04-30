using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
	public Transform FirePosition;
	public GameObject[] Magazine;

	private int ammoIndex;
	private GameObject currentProjectile;

	void Start()
	{
		currentProjectile = Magazine[ammoIndex];
	}
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate(currentProjectile, FirePosition.position, transform.rotation);
		}

		if (Input.mouseScrollDelta.magnitude != 0)
		{
			CycleIndex(Input.mouseScrollDelta.magnitude);
			currentProjectile = Magazine[ammoIndex];
		}
	}

	void CycleIndex(float vary)
	{
		if (vary > 0)
		{
			ammoIndex++;
			if (ammoIndex >= Magazine.Length)
			{
				ammoIndex = 0;
			}
		}
		else
		{
			ammoIndex--;
			if (ammoIndex < 0)
			{
				ammoIndex = Magazine.Length - 1;
			}
		}
	}
}
