using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolt : MonoBehaviour
{
	void FixedUpdate()
	{
		if (transform.position.z >= 10)
		{
			Destroy (this.gameObject);
		}
		transform.Translate (Vector3.forward * 10 * Time.deltaTime);
	}
}
