using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dan_Move : MonoBehaviour {
	public int correcGui;
	[SerializeField]
	public Text Score;
	public Sung_Move sung;
	public float speed;
	public Vector3 speed1;
	void Start () {
		sung = new Sung_Move ();
		correcGui = 0;
		speed1 = new Vector3 (3, 0, 0);
	}
	void Update () {

		transform.Translate (Vector3.up * 3 * Time.deltaTime);
		if (transform.position.y > 5.5f) {
			Destroy (this.gameObject);
		}
	}
	void OnCollisionEnter2D(Collision2D coll)
	{
		
	}
	void OnTriggerEnter2D(Collider2D Tager)
	{
		if (Tager.tag == "Ga") {
			BanDan.GetInstance ().StartMusic (Sounds.EFFECT);
			BanDan.GetInstance ().StartMusic (Sounds.BACKGROUND);
			Destroy (Tager.gameObject);
			Destroy (this.gameObject);
			correcGui++;
		}
	}
}
