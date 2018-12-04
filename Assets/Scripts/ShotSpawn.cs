using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawn : MonoBehaviour
{
	public GameObject Bolt;

	public bool ifSpawnBolt = false;

	void FixedUpdate()
	{
		if (ifSpawnBolt)
		{
			Instantiate (Bolt, transform.position, transform.rotation);
			ifSpawnBolt = false;
		}
	}
}
