using UnityEngine;
using System.Collections;

public class Player2D : MonoBehaviour {

	Rigidbody2D rigidbody;
	private float speed = 10;
	Vector2 velocity;

	void Start()
	{
		rigidbody = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized * speed;
	}

	void FixedUpdate()
	{
		rigidbody.MovePosition(rigidbody.position + velocity * Time.fixedDeltaTime);
	}

}
