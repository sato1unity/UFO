using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UFO_Move : MonoBehaviour {
	public float xspeed,yspeed;
	public Rigidbody2D Mybody;
	void Awake () {
		Mybody = GetComponent <Rigidbody2D>();
	}
	void FixedUpdate () {
		Mybody.velocity=new Vector2(xspeed,yspeed);
	}
	void OnCollisionEnter2D(Collision2D coli)
	{
		
	}
	void OnTriggerEnter2D(Collider2D target)
	{
		//if (target.tag=="SaoX") {
		//	Destroy (gameObject);
		//}
		//if (target.tag == "SaoD") {
		//	Destroy (target.gameObject);
		//	Destroy (gameObject);
		//}
		if (target.tag == "TuongY") {			
			yspeed = -yspeed;
			//xspeed = -xspeed;
			Mybody.velocity = new Vector2 (xspeed, yspeed);
		}
		if (target.tag == "Tuong") {			
			//yspeed = -yspeed;
			xspeed = -xspeed;
			Mybody.velocity = new Vector2 (xspeed, yspeed);
		}
		if (target.tag == "Ga") {
			xspeed = -xspeed;
			yspeed = -yspeed;
			Mybody.velocity = new Vector2 (xspeed, yspeed);
		}
	}
}
