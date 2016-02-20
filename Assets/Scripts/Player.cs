using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Rigidbody rigidbody;
	private float speed = 10;
	Vector3 velocity;

	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized * speed;
	}

	void FixedUpdate()
	{
		rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
	}

}
