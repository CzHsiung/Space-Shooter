using UnityEngine;

public class PlayerController : MonoBehaviour
{
	[System.Serializable]
	public class Boundary
	{
		public float XMax;
		public float XMin;
		public float ZMax;
		public float ZMin;
	}

	public float MoveSpeed = 5F;
	public float FiringSpeed = 0.3F;
	
	public Boundary boundary;
	public GameObject ShotSpawn;

	float isFireTime = 0;

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 moveMent = new Vector3(moveHorizontal, 0F, moveVertical);
		GetComponent<Rigidbody>().velocity = moveMent * MoveSpeed;
		transform.rotation = Quaternion.Euler (0F, 0F, moveHorizontal * -30F);
		transform.position = new Vector3(Mathf.Clamp(transform.position.x, boundary.XMin, boundary.XMax),
										0F,
										Mathf.Clamp(transform.position.z, boundary.ZMin, boundary.ZMax));
		if (Input.GetButtonDown("Fire"))
		{
			isFireTime = 0.5F;
		}
		if (Input.GetButton("Fire"))
		{
			if (isFireTime >= FiringSpeed)
			{
				isFireTime = 0F;
				ShotSpawn.GetComponent<ShotSpawn>().ifSpawnBolt = true;
			}
			isFireTime += Time.smoothDeltaTime;
		}
	}
}