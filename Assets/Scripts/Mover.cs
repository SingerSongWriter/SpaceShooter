using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public float speed;
	public float hSpeed; // horizontal speed

	void Start () 
	{
		rigidbody.velocity = transform.forward * speed;
//		rigidbody.velocity = new Vector3 (Random.Range (-hSpeed, hSpeed), 0, speed);
	}
}
