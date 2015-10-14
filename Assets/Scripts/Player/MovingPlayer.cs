using UnityEngine;
using System.Collections;

public class MovingPlayer : MonoBehaviour {

	public float speed;
	
	private Rigidbody2D rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		Vector2 movement = new Vector2 (0.0f,speed);
		
		rb.AddForce (movement);
	}

	void fixedUpdate (){

	}
}
